using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Processamento_de_Salários
{
    public partial class frmInserirEmpregado : Form
    {
        public frmInserirEmpregado()
        {
            InitializeComponent();
        }

        private void btnRegistar_Click(object sender, EventArgs e)
        {
            int.TryParse(tbOrdenado.Text, out int ordenado);
            if(ordenado == 0)
            {
                MessageBox.Show("O oredenado tem que ser maior que 0 ...");
                return;
            }

            double.TryParse(tbDescIRS.Text, out double descIRS);

            Empregado emp = new Empregado();
            emp.Referencia = tbReferencia.Text;
            emp.Nome = tbNome.Text;

            emp.Salario = ordenado;
            emp.DescontoIRS = descIRS;

            emp.NIF = tbNIF.Text;
            emp.NISS = tbNISS.Text;

            EmpregadoDAL dal = new EmpregadoDAL();

            dal.RegistarEmpregado(emp);

            //this.Close();

            LimparCampo();

        }

        private void LimparCampo()
        {
            tbReferencia.Text = "";
            tbNome.Text = "";
            tbOrdenado.Text = "";
            tbDescIRS.Text = "";
            tbNIF.Text = "";
            tbNISS.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
