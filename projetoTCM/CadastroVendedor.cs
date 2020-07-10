using ProjetoTCM.Business.General;
using ProjetoTCM.Domain.Enum;
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
    public partial class CadastroVendedor : Form
    {
        SalesmanBusiness salesmanBusiness = new SalesmanBusiness();
        public CadastroVendedor()
        {
            InitializeComponent();
        }

        private void CadastroVendedor_Load(object sender, EventArgs e)
        {
            LoadSalesman();
            ConfigurationDataGrid();
        }

        private void ConfigurationDataGrid()
        {

            dgVendedor.Columns[0].Visible = true;
            dgVendedor.Columns[1].Width = 260;
            dgVendedor.Columns[2].Width = 260;
            dgVendedor.Columns[3].Width = 150;
            dgVendedor.Columns[4].Width = 150;
            dgVendedor.Columns[5].Width = 150;
            dgVendedor.Columns[6].Visible = false;
        }

        private void LoadSalesman()
        {
            var result = salesmanBusiness.GetAll();
            if (result.Reply == ProjetoTCM.Infrastructure.Common.Enum.EnumReply.Success)
            {
                dgVendedor.DataSource = result.Entity;
            }
        }

        private void btnCadastrarVendedor_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save(long id = 0)
        {
            var salesman = new SalesmanDomain();
            salesman.ID = id;
            salesman.Name = txtName.Text;
            salesman.Email = txtEmail.Text;
            salesman.Address = txtAddress.Text;
            salesman.CPF = mskCpf.Text;
            salesman.Phone = mskPhone.Text;
            salesman.Sex = (cmbSexo.Text == "Masculino") ? EnumSex.Feminino : EnumSex.Outros;

            var result = salesmanBusiness.Save(salesman);
             if (result.Reply == ProjetoTCM.Infrastructure.Common.Enum.EnumReply.Success)
              {
               LoadSalesman();
               ClearSalesmanForm();
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
               private void Salesman()
                   {
                   var result = salesmanBusiness.GetAll();
                   if (result.Reply == ProjetoTCM.Infrastructure.Common.Enum.EnumReply.Success)
                   {
                   dgVendedor.DataSource = result.Entity;
                   }
            }
        private void ClearSalesmanForm()
        {
            txtName.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            cmbSexo.SelectedIndex = 0;
            mskCpf.Clear();
            mskPhone.Clear();
        }

        private void btnExcluirVendedor_Click(object sender, EventArgs e)
        {
            var salesmanID = Convert.ToInt64(dgVendedor.Rows[dgVendedor.CurrentCell.RowIndex].Cells["ID"].Value);

            var result = salesmanBusiness.Delete(salesmanID);
            if (result.Reply == ProjetoTCM.Infrastructure.Common.Enum.EnumReply.Success)
            {
                LoadSalesman();
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

        private void btnEditarVendedor_Click(object sender, EventArgs e)
            {
                if (btnEditarVendedor.Text == "EDITAR")
                {
                 txtName.Text = dgVendedor.Rows[dgVendedor.CurrentCell.RowIndex].Cells["Name"].Value.ToString();
                 txtAddress.Text = dgVendedor.Rows[dgVendedor.CurrentCell.RowIndex].Cells["Address"].Value.ToString();
                 txtEmail.Text = dgVendedor.Rows[dgVendedor.CurrentCell.RowIndex].Cells["Email"].Value.ToString();
                 mskCpf.Text = dgVendedor.Rows[dgVendedor.CurrentCell.RowIndex].Cells["CPF"].Value.ToString();
                 mskPhone.Text = dgVendedor.Rows[dgVendedor.CurrentCell.RowIndex].Cells["Phone"].Value.ToString();
                 cmbSexo.SelectedIndex = dgVendedor.Rows[dgVendedor.CurrentCell.RowIndex].Cells["Sex"].Value.ToString() == "MASCULINO" ? 0 :1 ;
                
                    btnCadastrarVendedor.Enabled = false;
                    btnExcluirVendedor.Enabled = false;
                    dgVendedor.Enabled = false;
                    btnEditarVendedor.Text = "SALVAR EDIÇÃO";
                }
                else
                {
                    var salesmanID = Convert.ToInt64(dgVendedor.Rows[dgVendedor.CurrentCell.RowIndex].Cells["ID"].Value);
                    Save(salesmanID);

                    dgVendedor.Enabled = true;
                    btnCadastrarVendedor.Enabled = true;
                    btnExcluirVendedor.Enabled = true;
                    btnEditarVendedor.Text = "EDITAR";
                }
            }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }


}
