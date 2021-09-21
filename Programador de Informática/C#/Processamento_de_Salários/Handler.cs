using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Processamento_de_Salários
{
    public class Handler
    {
        public void AlterarEmpregado(Empregado emp, string oldref)
        {
            
            EmpregadoDAL dal = new EmpregadoDAL();

            dal.AlterarEmpregado(emp, oldref);



        }
    }
}
