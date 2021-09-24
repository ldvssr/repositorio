using System;
using System.Collections.Generic;
using System.IO;

namespace Salarios_formacao
{
    public class EmpregadoDAL
    {
        private string path = @"C:\repositorio\Programador de Informática\C#\Salarios_formacao\Salarios_formacao\empregados.txt";
        public void RegistarEmpregado(Empregado emp)
        {
            string texto = ConcatenarEmpregado(emp);
            if (File.Exists(path))
            {
                // Se o ficheiro já existir
                File.AppendAllText(path, texto);
            }
            else
            {
                // Se o ficheiro não existir
                File.WriteAllText(path, texto);
            }
        }
        public string[] getTodosEmpregados()
        {
            try
            {
                string[] empregados = File.ReadAllLines(path);
                return empregados;
            }
            catch (Exception ex)
            {
                return null;
            }
            //return File.ReadAllLines(path);
        }
        private string ConcatenarEmpregado(Empregado emp)
        {
            string texto = "";
            texto += emp.Referencia.ToUpper() + ";";
            texto += emp.Nome + ";";
            texto += emp.Salario.ToString() + ";";
            texto += emp.Desconto_irs.ToString() + ";";
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
                    Desconto_irs = Convert.ToDouble(dados[3]),
                    NIF = dados[4],
                    NISS = dados[5]
                });
            }
            return Lista;
        }
        public void AlterarEmpregado(Empregado emp, string oldRef)
        {
            string registo = emp.Referencia.ToUpper() + ";";
            registo += emp.Nome + ";";
            registo += emp.Salario.ToString() + ";";
            registo += emp.Desconto_irs.ToString() + ";";
            registo += emp.NIF + ";";
            registo += emp.NISS + "\n";
            string[] listaempregados = File.ReadAllLines(path);
            File.WriteAllText(path, registo);
            foreach(string s in listaempregados)
            {
                string[] temp = s.Split(';');
                if(temp[0] != oldRef)
                {
                    File.AppendAllText(path, s + "\n");
                }
            }
        }
        public void EliminarEmpregado(string referencia)
        {
            string[] empregados = File.ReadAllLines(path);
            File.Delete(path);
            if(empregados.Length > 1)
            {
                int counter = 0;
                foreach(string line in empregados)
                {
                    string[] temp = line.Split(';');
                    if(temp[0] != referencia)
                    {
                        if (counter == 0)
                        {
                            File.WriteAllText(path, line + "\n");
                            counter++;
                        }
                        else
                            File.AppendAllText(path, line + "\n");
                    }               
                }
            }
        }

    }
}
