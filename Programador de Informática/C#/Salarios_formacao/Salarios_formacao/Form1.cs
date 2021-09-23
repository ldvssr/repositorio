using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salarios_formacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void inserirToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmInserirOperario fio = new frmInserirOperario();
            fio.ShowDialog();

        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarEmpregado fce = new frmConsultarEmpregado();
            fce.ShowDialog();
        }
    }
}
