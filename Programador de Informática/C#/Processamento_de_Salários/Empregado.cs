using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Processamento_de_Salários
{
    public class Empregado
    {
        private int faltas = 0;

        

        public string Referencia { get; set; }
        public string Nome { get; set; }
        public int Salario { get; set; }
        public double DescontoIRS { get; set; }
        public string NIF { get; set; }
        public string NISS { get; set; }

        public void setFaltas(int faltas)
        {
            this.faltas += faltas;
        }

        public int getFaltas()
        {
            return this.faltas;
        }

    }
}
