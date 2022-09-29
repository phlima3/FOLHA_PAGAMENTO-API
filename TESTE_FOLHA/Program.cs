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

        static List<ICalculoSalario> Empregados;
        static void Main(string[] args)
        {

            Empregados = new List<ICalculoSalario>();
            Empregados.Add(new Funcionario()
            {
                Cod = 1,
                Nome = "JOÃO DA SILVA",
                Horas = 160
            });

            Empregados.Add(new Funcionario()
            {
                Cod = 2,
                Nome = "PAULO MARCIO",
                Horas = 160
            });

            Empregados.Add(new Estagiario()
            {
                Cod = 3,
                Nome = "RENATO ARAGÃO",
                Horas = 160,
                Vale = 80,
            });


            Random faixa = new Random();

            Console.ForegroundColor = ConsoleColor.Green;
            foreach (ICalculoSalario emp in Empregados)
            {
                emp.Holerite(faixa.Next(18,35));
                Console.WriteLine("\n");
            }
            
            Console.ReadKey();


        }
    }
}
