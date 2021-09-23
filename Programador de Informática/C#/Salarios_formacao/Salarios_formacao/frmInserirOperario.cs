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
    public partial class frmInserirOperario : Form
    {
        public frmInserirOperario()
        {
            InitializeComponent();
        }

        private void frmInserirOperario_Load(object sender, EventArgs e)
        {
            //textBox1.Text = "Hello";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //button1.Text = "Hello";
        }

        private void btnRegistar_Click(object sender, EventArgs e)
        {
            int.TryParse(tbOrdenado.Text, out int ordenado);
            if (ordenado == 0)
            {
                MessageBox.Show("O ordenado tem que ser maior que 0...");
                return;
            }

            string referencia = tbReferencia.Text;

            Handler handler = new Handler();

            Boolean existe = handler.VerificarSeReferenciaExiste(referencia);

            if(existe)
            {
                MessageBox.Show("Essa referência já existe. Tem que inserir outra.");
                return;
            }



            double.TryParse(tbDescIrs.Text, out double desc_irs);

            Empregado emp = new Empregado();
            emp.Referencia = tbReferencia.Text;
            emp.Nome = tbNome.Text;

            emp.Salario = ordenado;
            emp.Desconto_irs = desc_irs;

            emp.NIF = tbNif.Text;
            emp.NISS = tbNiss.Text;

            EmpregadoDAL dal = new EmpregadoDAL();

            dal.RegistarEmpregado(emp);

            LimparCampos();
        }

        private void LimparCampos()
        {
            tbReferencia.Text = "";
            tbNome.Text = "";
            tbOrdenado.Text = "";
            tbDescIrs.Text = "";
            tbNif.Text = "";
            tbNiss.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
