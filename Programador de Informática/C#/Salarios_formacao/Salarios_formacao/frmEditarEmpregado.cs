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
    public partial class frmEditarEmpregado : Form
    {
        string oldRef = "";

        public frmEditarEmpregado()
        {
            InitializeComponent();
        }

        //public frmEditarEmpregado(Empregado emp)
        //{
        //    InitializeComponent();
        //}

        public void setValores(Empregado emp)
        {

            this.oldRef = emp.Referencia;

            tbReferencia.Text = emp.Referencia;
            tbNome.Text = emp.Nome;
            tbDescIrs.Text = emp.Desconto_irs.ToString();
            tbSalario.Text = emp.Salario.ToString();
            tbNif.Text = emp.NIF;
            tbNiss.Text = emp.NISS;


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string referencia = tbReferencia.Text;

            Handler handler = new Handler();

            Boolean existe = handler.VerificarSeReferenciaExiste(referencia);

            if (existe)
            {
                MessageBox.Show("Essa referência já existe. Tem que inserir outra.");
                return;
            }


            double.TryParse(tbDescIrs.Text, out double irs);
            int.TryParse(tbSalario.Text, out int salario);

            Empregado emp = new Empregado()
            {
                Referencia = tbReferencia.Text,
                Nome = tbNome.Text,
                Desconto_irs = irs,
                Salario = salario,
                NIF = tbNif.Text,
                NISS = tbNiss.Text
            };

            handler.AlterarEmpregado(emp, oldRef);

            MessageBox.Show("O registo foi alterado...");

            this.Close();

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
