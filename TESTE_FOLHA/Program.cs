using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using API_FOLHA;

namespace TESTE_FOLHA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICalculoSalario emp = new Funcionario()
            {
                Cod = 1,
                Nome = "JOÃO DA SILVA",
                Horas = 160
            };
            emp.Holerite(18);
            Console.ReadKey();


        }
    }
}
