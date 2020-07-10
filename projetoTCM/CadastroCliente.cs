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
    public partial class frmCadastroCliente : Form
    {
        ClientBusiness clientBusiness = new ClientBusiness();
       
            public frmCadastroCliente ()
                {
                    InitializeComponent();
                }
                     
        private void frmCadastroCliente_Load(object sender, EventArgs e)
        {
            LoadUsers();
            ConfigurationDataGrid();
        }
        
        private void ConfigurationDataGrid()
        {
            dtgCliente.Columns[0].Visible = true;
            dtgCliente.Columns[1].Width = 260;
            dtgCliente.Columns[2].Width = 260;
            dtgCliente.Columns[3].Width = 150;
            dtgCliente.Columns[4].Width = 150;
            dtgCliente.Columns[5].Width = 150;
            dtgCliente.Columns[6].Visible = false;       
        }
        private void LoadUsers()
        {
            var result = clientBusiness.GetAll();
            if (result.Reply == ProjetoTCM.Infrastructure.Common.Enum.EnumReply.Success)
            {
                dtgCliente.DataSource = result.Entity;
            }
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            Save();
        }


        private void Save(long id = 0)
        {
            var client = new ClientDomain();
            client.ID = id;
            client.Name = txtNome.Text;
            client.Email = txtEmail.Text;
            client.CPF = mkdCpf.Text;
            client.Phone = mkdPhone.Text;
            client.CellPhone = mkdCellPhone.Text;
            client.Sex = (cmbSex.Text == "Masculino") ? EnumSex.Feminino : EnumSex.Outros;

            var result = clientBusiness.Save(client);
            if (result.Reply == ProjetoTCM.Infrastructure.Common.Enum.EnumReply.Success)
            {
                LoadUsers();
                ClearClientForm();
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

        private void ClearClientForm()
        {
            txtNome.Clear();
            txtEmail.Clear();
            mkdCpf.Clear();
            mkdPhone.Clear();
            mkdCellPhone.Clear();
        }

        private void btnExcluirCliente_Click(object sender, EventArgs e)
        {
            var ClientID = Convert.ToInt64(dtgCliente.Rows[dtgCliente.CurrentCell.RowIndex].Cells["ID"].Value);

            var result = clientBusiness.Delete(ClientID);
            if (result.Reply == ProjetoTCM.Infrastructure.Common.Enum.EnumReply.Success)
            {
                LoadClient();
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

        private void LoadClient()
        {
            var result = clientBusiness.GetAll();
            if (result.Reply == ProjetoTCM.Infrastructure.Common.Enum.EnumReply.Success)
            {
                dtgCliente.DataSource = result.Entity;
            }
        }

        private void BtnEditarCliente_Click(object sender, EventArgs e)
        {
            if (BtnEditarCliente.Text == "EDITAR")
            {
                txtNome.Text = dtgCliente.Rows[dtgCliente.CurrentCell.RowIndex].Cells["Name"].Value.ToString();
                txtEmail.Text = dtgCliente.Rows[dtgCliente.CurrentCell.RowIndex].Cells["Email"].Value.ToString();
                mkdCpf.Text = dtgCliente.Rows[dtgCliente.CurrentCell.RowIndex].Cells["Cpf"].Value.ToString();
                mkdPhone.Text = dtgCliente.Rows[dtgCliente.CurrentCell.RowIndex].Cells["Phone"].Value.ToString();
                mkdCellPhone.Text = dtgCliente.Rows[dtgCliente.CurrentCell.RowIndex].Cells["CellPhone"].Value.ToString();
                cmbSex.Text = dtgCliente.Rows[dtgCliente.CurrentCell.RowIndex].Cells["Sex"].Value.ToString();

                btnCadastrarCliente.Enabled = false;
                btnExcluirCliente.Enabled = false;
                dtgCliente.Enabled = false;
                BtnEditarCliente.Text = "SALVAR EDIÇÃO";
            }
            else
            {
                var clientID = Convert.ToInt64(dtgCliente.Rows[dtgCliente.CurrentCell.RowIndex].Cells["ID"].Value);
                Save(clientID);

                dtgCliente.Enabled = true;
                btnCadastrarCliente.Enabled = true;
                btnExcluirCliente.Enabled = true;
                BtnEditarCliente.Text = "EDITAR";
            }
        }
    }

}


