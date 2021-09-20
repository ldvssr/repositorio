using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Processamento_de_Salários
{
    public class EmpregadoDAL
    {
        private string path = @"C:\github\repositorio\Programador de Informática\C#\Processamento_de_Salários\empregados.txt";
        public void RegistarEmpregado(Empregado emp)
        {
            
            string texto = ConcatenarEmpregado(emp);

            if(File.Exists(path))
            {
                File.AppendAllText(path, texto);
            }
            else
            {
                File.WriteAllText(path, texto);
            }
                        
        }

        private string ConcatenarEmpregado(Empregado emp)
        {
            
            string texto = "";
            texto += emp.Referencia + ";";
            texto += emp.Nome + ";";
            texto += emp.Salario.ToString() + ";";
            texto += emp.DescontoIRS.ToString() + ";";
            texto += emp.NIF + ";";
            texto += emp.NISS + "\n";

            return texto;
        }
    }
}
