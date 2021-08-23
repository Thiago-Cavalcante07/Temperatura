using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransformandoValor
{
    class Program
    {
        static void Main(string[] args)
        {
            double real = 5.22;
            double dolar;
            double totalReal;

            Console.WriteLine("Coversor de Real para Dolar: ");

            Console.Write("\nInforme Quantos dolares você tem? ");
            dolar = double.Parse(Console.ReadLine());

            totalReal = dolar * 5.22;

            Console.WriteLine("\nCom " + dolar + " Dolares você compra R$ " + totalReal + " Reais");


            Console.ReadLine();
        }
    }
}
