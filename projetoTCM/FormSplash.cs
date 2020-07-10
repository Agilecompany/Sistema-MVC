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
    public partial class frmtelaSplash : Form
    {
        public frmtelaSplash()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if(pbCarrega.Value < 100)
            {
                pbCarrega.Value = pbCarrega.Value + 2;
            }
            else
            {
                timer1.Enabled = false;
                this.Visible = false;
                frmLogin login = new frmLogin();
                login.ShowDialog();
            }
        }

        private void pbCarrega_Click(object sender, EventArgs e)
        {

        }
    }
}
