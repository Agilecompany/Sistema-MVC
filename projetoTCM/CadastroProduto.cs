using ProjetoTCM.Business.General;
using ProjetoTCM.Domain.General;
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
    public partial class CadastroProdutos : Form
    {
        ProductBusiness productBusiness = new ProductBusiness();

        public CadastroProdutos()
        {
            InitializeComponent();
        }

        private void CadastroProdutos_Load(object sender, EventArgs e)
        {
            LoadUsers();
            ConfigurationDataGrid();
        }

        private void ConfigurationDataGrid()
        {
            dtgProduto.Columns[0].Visible = true;
            dtgProduto.Columns[1].Width = 260;
            dtgProduto.Columns[2].Width = 260;
            dtgProduto.Columns[3].Width = 150;
            dtgProduto.Columns[4].Width = 150;
            dtgProduto.Columns[5].Width = 150;
            dtgProduto.Columns[6].Visible = false;
        }

        private void LoadUsers()
        {
            var result = productBusiness.GetAll();
            if (result.Reply == ProjetoTCM.Infrastructure.Common.Enum.EnumReply.Success)
            {
                dtgProduto.DataSource = result.Entity;
            }

        }

        private void btnCadastrarProduto_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save(long id = 0 )
        {
            var product = new ProductDomain();
            product.ID = id;
            product.Name = txtNome.Text;
            product.Brand = txtMarca.Text;
            product.Description = txtDescricao.Text;
            product.ExternalCode = txtCodigo.Text;
            product.Model = cmbTipoProduto.Text;
            product.UnitPrice = decimal.Parse(txtPreco.Text.Replace("R$ ", ""));

        var result = productBusiness.Save(product);
            if (result.Reply == ProjetoTCM.Infrastructure.Common.Enum.EnumReply.Success)
            {
                LoadUsers();
                ClearProductForm();
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

        private void ClearProductForm()
        {
            txtNome.Clear();
            txtPreco.Clear();
            txtMarca.Clear();
            txtDescricao.Clear();
            txtCodigo.Clear();
        }

        private void btnExcluirProduto_Click(object sender, EventArgs e)
        {
            var ProductID = Convert.ToInt64(dtgProduto.Rows[dtgProduto.CurrentCell.RowIndex].Cells["ID"].Value);

            var result = productBusiness.Delete(ProductID);
            if (result.Reply == ProjetoTCM.Infrastructure.Common.Enum.EnumReply.Success)
            {
                LoadProduct();
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

        private void LoadProduct()
        {
            var result = productBusiness.GetAll();
            if (result.Reply == ProjetoTCM.Infrastructure.Common.Enum.EnumReply.Success)
            {
                dtgProduto.DataSource = result.Entity;
            }

        }

        private void btnEditarProduto_Click(object sender, EventArgs e)
        {
            if (btnEditarProduto.Text == "EDITAR")
            {
             txtNome.Text = dtgProduto.Rows[dtgProduto.CurrentCell.RowIndex].Cells["Name"].Value.ToString();
             txtCodigo.Text = dtgProduto.Rows[dtgProduto.CurrentCell.RowIndex].Cells["ExternalCode"].Value.ToString();
             txtDescricao.Text = dtgProduto.Rows[dtgProduto.CurrentCell.RowIndex].Cells["Description"].Value.ToString();
             txtMarca.Text = dtgProduto.Rows[dtgProduto.CurrentCell.RowIndex].Cells["Brand"].Value.ToString();
             txtPreco.Text = ((decimal)(dtgProduto.Rows[dtgProduto.CurrentCell.RowIndex].Cells["UnitPrice"].Value)).ToString("C2"); 
             cmbTipoProduto.Text = dtgProduto.Rows[dtgProduto.CurrentCell.RowIndex].Cells["Model"].Value.ToString();

                btnCadastrarProduto.Enabled = false;
                btnExcluirProduto.Enabled = false;
                dtgProduto.Enabled = false;
                btnEditarProduto.Text = "SALVAR EDIÇÃO";
            }
            else
            {
                var ProductID = Convert.ToInt64(dtgProduto.Rows[dtgProduto.CurrentCell.RowIndex].Cells["ID"].Value);
                Save(ProductID);

                dtgProduto.Enabled = true;
                btnCadastrarProduto.Enabled = true;
                btnExcluirProduto.Enabled = true;
                btnEditarProduto.Text = "EDITAR";
            }
        }
    }
}
