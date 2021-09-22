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
    public partial class frmEditarEmpregado : Form
    {
        
        string oldref = "";
        
        public frmEditarEmpregado()
        {
            InitializeComponent();
        }

        public void setValores(Empregado emp)
        {

            oldref = emp.Referencia;

            tbReferencia.Text = emp.Referencia;
            tbNome.Text = emp.Nome;
            tbSalario.Text = emp.Salario.ToString();
            tbDescIRS.Text = emp.DescontoIRS.ToString();
            tbNIF.Text = emp.NIF;
            tbNISS.Text = emp.NISS;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            double.TryParse(tbDescIRS.Text, out double irs);
            int.TryParse(tbSalario.Text, out int salario);
            
            Empregado emp = new Empregado()
            {
                Referencia = tbReferencia.Text,
                Nome = tbNome.Text,
                DescontoIRS = irs,
                Salario = salario,
                NIF = tbNIF.Text,
                NISS = tbNISS.Text
            };

            Handler handler = new Handler();
            handler.AlterarEmpregado(emp, oldref);

            MessageBox.Show("O registo foi alterado...");

            this.Close();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
