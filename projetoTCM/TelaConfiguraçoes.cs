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
    public partial class TelaConfiguraçoes : Form
    {
        public TelaConfiguraçoes()
        {
            InitializeComponent();
        }

        private void TelaConfiguraçoes_Load(object sender, EventArgs e)
        {

        }

        private void btnCalendario_Click(object sender, EventArgs e)
        {
            FormCalendario Calendario = new FormCalendario();
            Calendario.ShowDialog();
        }
    }
}
