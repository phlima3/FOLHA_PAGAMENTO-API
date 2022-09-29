using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_FOLHA
{
    public interface ICalculoSalario
    {
        string Nome { get; set; }
        double Calcular(double SalarioHora);
        double Desconto(double Salario);
        void Holerite(double salHora);

    }
}
