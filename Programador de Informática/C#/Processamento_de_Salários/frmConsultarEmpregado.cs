﻿using System;
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
    public partial class frmConsultarEmpregado : Form
    {
        public List<Empregado> empregados = new List<Empregado>();
        
        public frmConsultarEmpregado()
        {
            empregados = GetEmpregados();
            InitializeComponent();
        }

        private List<Empregado> GetEmpregados()
        {
            EmpregadoDAL dal = new EmpregadoDAL();

            var lista = dal.GetAllEmpregados();

            //return dal.GetAllEmpregados();
            return lista;
        }

        private void frmConsultarEmpregado_Load(object sender, EventArgs e)
        {
            LerLista();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedRow = dataGridView1.SelectedRows[0].DataBoundItem as Empregado;

                frmEditarEmpregado fee = new frmEditarEmpregado();


                fee.setValores(selectedRow);

                fee.ShowDialog();


                this.empregados = GetEmpregados();

                LerLista();
                            
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um erro. " + ex.Message);
                
            }
        }

        private void LerLista()
        {
            var empregados = this.empregados;

            if (empregados == null)
            {
                MessageBox.Show("Sem dados para mostrar...");
                this.Close();
            }

            dataGridView1.DataSource = empregados;

            dataGridView1.Columns["Referencia"].Visible = false;
        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
