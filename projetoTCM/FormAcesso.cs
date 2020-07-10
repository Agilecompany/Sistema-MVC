using ProjetoTCM.Business.Security;
using ProjetoTCM.Domain.Enum;
using ProjetoTCM.Domain.Security;
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
    public partial class FormAcesso : Form
    {
        UserBusiness userBusiness = new UserBusiness();

        public FormAcesso()
        {
            InitializeComponent();
        }

        private void FormAcesso_Load(object sender, EventArgs e)
        {
            LoadUsers();
            ConfigurationDataGrid();
        }

        private void ConfigurationDataGrid()
        {
            dgAcesso.Columns[0].Visible = false;
            dgAcesso.Columns[1].Width = 260;
            dgAcesso.Columns[2].Width = 260;
            dgAcesso.Columns[3].Width = 150;
            dgAcesso.Columns[4].Width = 150;
            dgAcesso.Columns[5].Width = 150;
            dgAcesso.Columns[6].Visible = false;
        }

        
        private void LoadUsers()
        {
            var result = userBusiness.GetAll();
            if (result.Reply == ProjetoTCM.Infrastructure.Common.Enum.EnumReply.Success)
            {
                dgAcesso.DataSource = result.Entity;
            }
        }

        private void btnCadastrarAcesso_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save(long id = 0)
        {
            var user = new UserDomain();
            user.ID = id;
            user.Name = txtName.Text;
            user.Email = txtEmail.Text;
            user.Login = txtLogin.Text;
            user.Password = txtPassword.Text;
            user.Profile = (cmbProfile.Text == "Adminstrador") ? EnumProfile.Admin : EnumProfile.Cashier;

            var result = userBusiness.Save(user);
            if (result.Reply == ProjetoTCM.Infrastructure.Common.Enum.EnumReply.Success)
            {
                LoadUsers();
                ClearUserForm();
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

        private void ClearUserForm()
        {
            txtName.Clear();
            txtEmail.Clear();
            txtLogin.Clear();
            txtPassword.Clear();
            cmbProfile.SelectedIndex = 0;
        }

        private void btnExcluirAcesso_Click(object sender, EventArgs e)
        {
            var userID = Convert.ToInt64(dgAcesso.Rows[dgAcesso.CurrentCell.RowIndex].Cells["ID"].Value);

            var result = userBusiness.Delete(userID);
            if (result.Reply == ProjetoTCM.Infrastructure.Common.Enum.EnumReply.Success)
            {
                LoadUsers();
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

        private void btnEditarAcesso_Click(object sender, EventArgs e)
        {
            if (btnEditarAcesso.Text == "EDITAR")
            {
                txtName.Text = dgAcesso.Rows[dgAcesso.CurrentCell.RowIndex].Cells["Name"].Value.ToString();
                txtEmail.Text = dgAcesso.Rows[dgAcesso.CurrentCell.RowIndex].Cells["Email"].Value.ToString();
                txtLogin.Text = dgAcesso.Rows[dgAcesso.CurrentCell.RowIndex].Cells["Login"].Value.ToString();
                txtPassword.Text = dgAcesso.Rows[dgAcesso.CurrentCell.RowIndex].Cells["Password"].Value.ToString();
                cmbProfile.SelectedIndex = dgAcesso.Rows[dgAcesso.CurrentCell.RowIndex].Cells["Profile"].Value.ToString() == "Administrador" ? 0 : 1;

                btnCadastrarAcesso.Enabled = false;
                btnExcluirAcesso.Enabled = false;
                dgAcesso.Enabled = false;
                btnEditarAcesso.Text = "SALVAR EDIÇÃO";
            }
            else
            {
                var userID = Convert.ToInt64(dgAcesso.Rows[dgAcesso.CurrentCell.RowIndex].Cells["ID"].Value);
                Save(userID);

                dgAcesso.Enabled = true;
                btnCadastrarAcesso.Enabled = true;
                btnExcluirAcesso.Enabled = true;
                btnEditarAcesso.Text = "EDITAR";
            }
        }
    }
}
