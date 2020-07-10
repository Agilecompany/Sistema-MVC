using ProjetoTCM.Business.General;
using ProjetoTCM.Business.Sale;
using ProjetoTCM.Domain.Enum;
using ProjetoTCM.Domain.General;
using ProjetoTCM.Domain.Sale;
using ProjetoTCM.Infrastructure.Common.Message;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoTCM
{
    public partial class TelaVenda : Form
    {
        public TelaVenda()
        {
            InitializeComponent();

        }

        private void TelaVenda_Load(object sender, EventArgs e)
        {
            

            cmbCliente.DisplayMember = "Name";
            cmbCliente.ValueMember = "ID";
            cmbCliente.DataSource = new ClientBusiness().GetAll().Entity.OrderBy(x => x.Name).ToList();

            cmbVendedor.DisplayMember = "Name";
            cmbVendedor.ValueMember = "ID";
            cmbVendedor.DataSource = new SalesmanBusiness().GetAll().Entity.OrderBy(x => x.Name).ToList();

            cmbProduct.DisplayMember = "ExternalCodeName";
            cmbProduct.ValueMember = "ID";
            cmbProduct.DataSource = new ProductBusiness().GetAll().Entity;

            cmbFormaPagamento.DisplayMember = "Name";
            cmbFormaPagamento.ValueMember = "ID";
            cmbFormaPagamento.DataSource = new List<object> 
            { 
                new { ID = (short)EnumPayment.Credito, Name = EnumPayment.Credito.ToString()  },
                new { ID = (short)EnumPayment.Debito, Name = EnumPayment.Debito.ToString()  },
                new { ID = (short)EnumPayment.Dinheiro, Name = EnumPayment.Dinheiro.ToString()  }
            };

            txtAtendente.Text = ((mdiMenu)this.TopLevelControl).UserDomanActive.Name;
            mskSaleDate.Text = DateTime.Now.ToString("dd/MM/yyyy");

            ClearSaleForm();
            ClearSaleProductForm();

            dgProduct1.DataSource = new List<SaleProductDomain>();
            dgProduct1.Columns[0].Visible = false;
            dgProduct1.Columns[1].Visible = false;
        }

        private void btnIncluirProduto_Click(object sender, EventArgs e)
        {
            List<SaleProductDomain> currentItems = (List<SaleProductDomain>)dgProduct1.DataSource;

            currentItems.Add(new SaleProductDomain()
            {
                ProductID = ((ProductDomain)cmbProduct.SelectedItem).ID,
                ExternalCode = ((ProductDomain)cmbProduct.SelectedItem).ExternalCode,
                ProductName = ((ProductDomain)cmbProduct.SelectedItem).Name,
                Quantity = Convert.ToInt32(numQuantidade.Text),
                UnitPrice = ((ProductDomain)cmbProduct.SelectedItem).UnitPrice
            });

            dgProduct1.DataSource = null;
            dgProduct1.DataSource = currentItems;
            dgProduct1.Columns[0].Visible = false;
            dgProduct1.Columns[1].Visible = false;
            SetTotal(currentItems);
            ClearSaleProductForm();
        }

        private void SetTotal(List<SaleProductDomain> currentItems)
        {
            txtTotal.Text = currentItems.Sum(z => z.UnitPrice * z.Quantity).ToString("C2");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var productID = Convert.ToInt64(dgProduct1.Rows[dgProduct1.CurrentCell.RowIndex].Cells["ProductID"].Value);

            List<SaleProductDomain> currentItems = (List<SaleProductDomain>)dgProduct1.DataSource;

            dgProduct1.DataSource = null;
            dgProduct1.DataSource = currentItems.FindAll(x => x.ProductID != productID);
            dgProduct1.Columns[0].Visible = false;
            dgProduct1.Columns[1].Visible = false;

            SetTotal(currentItems);
        }

        private void btnConcluirVenda_Click(object sender, EventArgs e)
        {
            var sale = new SaleDomain();
            sale.ClientCPF = ((ClientDomain)cmbCliente.SelectedItem).CPF;
            sale.ClientID = ((ClientDomain)cmbCliente.SelectedItem).ID;
            sale.ClientName = ((ClientDomain)cmbCliente.SelectedItem).Name;
            sale.Date = DateTime.Now.Date;
            sale.Payment = (EnumPayment)((dynamic)cmbFormaPagamento.SelectedItem).ID;
            sale.SalesmanID = ((SalesmanDomain)cmbVendedor.SelectedItem).ID;
            sale.SalesmanName = ((SalesmanDomain)cmbVendedor.SelectedItem).Name;
            sale.UserID = ((mdiMenu)this.TopLevelControl).UserDomanActive.ID;
            sale.SaleProducts = (List<SaleProductDomain>)dgProduct1.DataSource;

            var result = new SaleBusiness().Save(sale);
            if (result.Reply == ProjetoTCM.Infrastructure.Common.Enum.EnumReply.Success)
            {
                ClearSaleForm();
            }
            else if (result.Reply == ProjetoTCM.Infrastructure.Common.Enum.EnumReply.BusinessError)
            {
                MessageBox.Show(result.Message, MessageResource.MsgBoxTitleWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            else
            {
                MessageBox.Show(result.Message, MessageResource.MsgBoxTitleError, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void ClearSaleProductForm()
        {
            cmbProduct.SelectedIndex = -1;
            numQuantidade.Text = "1";
        }

        private void ClearSaleForm()
        {
            cmbCliente.SelectedIndex = -1;
            cmbVendedor.SelectedIndex = -1;
            cmbFormaPagamento.SelectedIndex = -1;
            dgProduct1.DataSource = null;
            dgProduct1.DataSource = new List<SaleProductDomain>();
            dgProduct1.Columns[0].Visible = false;
            dgProduct1.Columns[1].Visible = false;
            SetTotal((List<SaleProductDomain>)dgProduct1.DataSource);

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dgProduct1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

