using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Salarios_formacao
{
    public class Empregado
    {
        public string Referencia { get; set; }
        public string Nome { get; set; }
        public int Salario { get; set; }
        public double Desconto_irs { get; set; }
        public String NIF { get; set; }
        public String NISS { get; set; }
    }
}
