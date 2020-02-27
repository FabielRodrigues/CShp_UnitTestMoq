using System;
using System.Collections.Generic;
using System.Text;

namespace CShp_UnitTestMoq
{
    public interface ICalculadora
    {
        (string operacao, double resultado) Calcular(string operacao, double a, double b);
    }
}
