using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoTCM.Domain.Security;

namespace projetoTCM
{
    public partial class mdiMenu : Form
    {
        private int childFormNumber = 0;

        protected Form FormAtivo { get; set; }
        public UserDomain UserDomanActive { get; internal set; }

        public mdiMenu()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            FormAtivo = new Form();
            FormAtivo.MdiParent = this;
            FormAtivo.Text = "Window " + childFormNumber++;
            FormAtivo.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnslide_Click(object sender, EventArgs e)

        {

            if (menuVertical.Width == 195)
            {
                menuVertical.Width = 57;
            }
            else
            {
                menuVertical.Width = 195;
            }
            FormAtivo.Width = this.Width - menuVertical.Width - 4;
        }


        private void mdiMenu_Load(object sender, EventArgs e)
        {
            AbrirFormulario( new FormHome());
            timer1.Enabled = true;
            timer1.Start();
        }


        private void AbrirFormulario(Form formulario)
        {
            FormAtivo?.Close();
            FormAtivo = formulario;
            FormAtivo.Top = 0;
            FormAtivo.Left = 0;

            FormAtivo.MdiParent = this;
            FormAtivo.Height = this.Height - barraTitulo.Height - 28;
            FormAtivo.Width = this.Width - menuVertical.Width - 4;
            FormAtivo.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormHome());
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToString("dd/MMM/yyyy HH:MM:ss");
           
        }

        private void cLIENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
             AbrirFormulario(new frmCadastroCliente());

        }

        private void vENDEDORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new CadastroVendedor());
        }

        private void pRODUTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new CadastroProdutos());
        }

        private void aCESSOAOSISTEMAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormAcesso());
        }

        private void sOBREToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormSobre ());
        }

        private void cALENDÁRIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormCalendario());
        }

        private void fAZERLOGOFFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmtelaSplash telasplash = new frmtelaSplash();
            telasplash.ShowDialog();
        }

        private void aLTERARTEMAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.BackColor == Color.FromArgb(255, 255, 192))
            {
                this.BackColor = Color.FromArgb(0, 192, 192);
                
            }
            else
            {
                if (this.BackColor == Color.FromArgb(0, 192, 192))
                {
                    this.BackColor = Color.FromArgb(255, 255, 192);
                }
            }
        }




         private void acessoAoSistemaToolStripMenuItem_Click(object sender, EventArgs e)
          {
             AbrirFormulario(new FormAcesso());
          }

        private void vENDAToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new TelaVenda());
        }

        private void cONSULTAVENDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new ConsultaVenda());
        }
    }
}
