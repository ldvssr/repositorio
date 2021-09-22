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

        public List<Empregado> GetAllEmpregados()
        {
            var Lista = new List<Empregado>();

            if(!File.Exists(path))
            {
                Lista = null;
                return Lista;
            }

            foreach(string line in File.ReadLines(path))
            {
                string[] dados = line.Split(';');
                Lista.Add(new Empregado()
                {
                    Referencia = dados[0],
                    Nome = dados[1],
                    Salario = Convert.ToInt32(dados[2]),
                    DescontoIRS = Convert.ToDouble(dados[3]),
                    NIF = dados [4],
                    NISS = dados [5]
                });
            }

            return Lista;

        }

        public void AlterarEmpregado(Empregado emp, string oldref)
        {

            string registo = emp.Referencia + ";";
            registo += emp.Nome + ";";
            registo += emp.Salario + ";";
            registo += emp.DescontoIRS + ";";
            registo += emp.NIF + ";";
            registo += emp.NISS + "\n";
            
            string[] listaempregados = File.ReadAllLines(path);

            File.WriteAllText(path, registo);

            foreach (string s in listaempregados)
            {
                string[] temp = s.Split(';');

                if (temp[0] != oldref)
                {
                    File.AppendAllText(path, s + "\n");
                }

            }

        }

    }
}
