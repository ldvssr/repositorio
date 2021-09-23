using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salarios_formacao
{
    public class Handler
    {

        public void AlterarEmpregado(Empregado emp, string oldRef)
        {

            EmpregadoDAL dal = new EmpregadoDAL();

            dal.AlterarEmpregado(emp, oldRef);


        }


        public bool VerificarSeReferenciaExiste(string referencia)
        {
            bool existe = false;

            EmpregadoDAL dal = new EmpregadoDAL();

            string[] empregados = dal.getTodosEmpregados();

            foreach(string s in empregados)
            {
                string[] temp = s.Split(';');

                if (temp[0] == referencia) existe = true;
            }

            return existe;

        }
    }
}
