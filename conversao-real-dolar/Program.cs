using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double reais, dolar;
            Console.WriteLine("Escreva o valor em reais");
            reais = double.Parse(Console.ReadLine());
            dolar = reais / 5.33;
            Console.WriteLine("Resultado em dolar:" + dolar.ToString("n2"));



        }
    }
}
