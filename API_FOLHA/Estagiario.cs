using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_FOLHA
{
    public class Estagiario:ICalculoSalario
    {
        public int Cod { get; set; }
        public string Nome { get; set; }
        public double Horas { get; set; }
        public double Vale { get; set; }

        public Estagiario(int Cod, string Nome, double Horas, double Vale)
        {
            this.Cod = Cod;
            this.Nome = Nome;
            this.Horas = Horas;
            this.Vale = Vale;
        }

        public Estagiario():this(0,"",0,50f)
        {

        }

        public double Calcular(double SalarioHora)
        {
            double sb = Horas * SalarioHora;
            if (sb > 1200) return 1212;
            else return sb;
        }

        public double Desconto(double Salario)
        {
            return 0;
        }
        public void Holerite(double salHora)
        {
            double sb = Calcular(18);
            Console.WriteLine("ESTAGIARIO: {0}", Nome);
            Console.WriteLine("Salario Bruto:{0:C2}", sb);
            double desc = Desconto(sb);
            Console.WriteLine("Desconto:{0:C2}", desc);
            Vale = sb * 0.10;
            Console.WriteLine("vale: {0:C2}", Vale);
            double sl = sb - desc;
            Console.WriteLine("Sal líquido:{0:C2}",
                sl);
        }
    }
}
