using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_FOLHA
{
    public class Funcionario : ICalculoSalario
    {
        public int Cod { get; set; }
        public string Nome { get; set; }
        public double Horas { get; set; }

        public Funcionario(int Cod, string Nome, double Horas)
        {
            this.Cod = Cod;
            this.Nome = Nome;
            this.Horas = Horas;
        }

        public Funcionario() : this(0, "", 0f)
        {

        }

        public double Calcular(double SalarioHora)
        {
            double sb = Horas * SalarioHora;
            return sb;
        }

        public double Desconto(double Salario)
        {
            double valor = Salario * 0.02;
            return valor;
        }
        public void Holerite(double salHora)
        {
             double sb = Calcular(18);
            Console.WriteLine("Salario Bruto:{0:C2}", sb);
            double desc = Desconto(sb);
            Console.WriteLine("Desconto:{0:C2}", desc);
            double sl = sb - desc;
            Console.WriteLine("Sal líquido:{0:C2}",
                sl);
        }
    }
}
