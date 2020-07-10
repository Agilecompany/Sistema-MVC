using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using ProjetoTCM.Business.Security;
using ProjetoTCM.Infrastructure.Common.Message;

namespace projetoTCM
{
    public partial class frmLogin : Form
    {
        UserBusiness userBusiness = new UserBusiness();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            DoLogin();
        }

        private void DoLogin()
        {
            var result = userBusiness.Authentication(textLogin.Text, textSenha.Text);
            if (result.Reply == ProjetoTCM.Infrastructure.Common.Enum.EnumReply.Success)
            {
                MessageBox.Show($"{result.Message} {result.Entity.Name}", MessageResource.MsgBoxTitleSuccess, MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close(); //Fecha o formulário de login
                mdiMenu mn = new mdiMenu(); //Instancia o formulário menu
                mn.UserDomanActive = result.Entity;
                mn.Show(); // Carrega o formulário menu através da variável que representa a instancia "mn"
            }
            else if (result.Reply == ProjetoTCM.Infrastructure.Common.Enum.EnumReply.BusinessError)
            {
                MessageBox.Show(result.Message, MessageResource.MsgBoxTitleWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show(result.Message, MessageResource.MsgBoxTitleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textSenha_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                DoLogin();
            }
        }

        private void textLogin_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DoLogin();
            }
        }
    }
}
