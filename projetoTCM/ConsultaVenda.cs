using ProjetoTCM.Business.Sale;
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
    public partial class ConsultaVenda : Form
    {
        List<SaleDomain> sales = new List<SaleDomain>();
        List<SaleProductDomain> saleProduct = new List<SaleProductDomain>();

        public ConsultaVenda()
        {
            InitializeComponent();
        }

        private void ConsultaVenda_Load(object sender, EventArgs e)
        {
            LoadSales();

        }

        private void LoadSales()
        {
            sales = new SaleBusiness().GetAll().Entity.OrderByDescending(x => x.Date).ToList();
            saleProduct = new SaleProductBusiness().GetAll().Entity.OrderByDescending(q => q.UnitPrice * q.Quantity).ToList();

            dgSale.DataSource = sales;
            dgSale.Columns[0].Visible = false;
            dgSale.Columns[3].Visible = false;
            dgSale.Columns[4].Visible = false;
            dgSale.Columns[5].Visible = false;
            dgSale.Columns[6].Visible = false;
            if (dgSale.Rows.Count > 0) dgSale.Rows[0].Selected = true;
            ShowProduct();
        }

        private void ShowProduct()
        {
            if (dgSale.Rows.Count > 0)
            {
                var saleID = (dgSale.CurrentCell == null)? sales.FirstOrDefault().ID : Convert.ToInt64(dgSale.Rows[dgSale.CurrentCell.RowIndex].Cells["ID"].Value);
                dgSaleProduct.DataSource = saleProduct.FindAll(q => q.SaleID == saleID);
                dgSaleProduct.Columns[0].Visible = false;
                dgSaleProduct.Columns[1].Visible = false;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var saleID = Convert.ToInt64(dgSale.Rows[dgSale.CurrentCell.RowIndex].Cells["ID"].Value);

            var result = new SaleBusiness().Delete(saleID);
            if (result.Reply == ProjetoTCM.Infrastructure.Common.Enum.EnumReply.Success)
            {
                LoadSales();
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

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            var filter = txtFiltro.Text;

            var salesResult = sales.FindAll(x => x.ClientCPF.Contains(filter)
            || x.ClientName.Contains(filter)
            || x.Date.ToString("dd/MM/yyyy").Contains(filter)
            || x.Payment.ToString().Contains(filter)
            || x.SalesmanName.Contains(filter)).Select(q => q.ID).ToList();

            var saleProductResult = saleProduct.FindAll(x => x.ExternalCode.Contains(filter)
            || x.ProductName.Contains(filter)
            || x.Quantity.ToString("dd/MM/yyyy").Contains(filter)
            || x.SubTotal.ToString().Contains(filter)
            || x.UnitPrice.ToString("C2").Contains(filter)).Select(q => q.SaleID).ToList();

            var allIDs = new List<long>();
            allIDs.AddRange(salesResult);
            allIDs.AddRange(saleProductResult);
            allIDs = allIDs.Distinct().ToList();

            dgSale.DataSource = sales.FindAll(q => allIDs.Contains(q.ID));

            if (dgSale.Rows.Count > 0) dgSale.Rows[0].Selected = true;
            ShowProduct();

        }

     
        private void dgSale_SelectionChanged(object sender, EventArgs e)
        {
            ShowProduct();
        }

    }
}
