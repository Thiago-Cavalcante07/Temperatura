using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeMulta
{
    class Program
    {
        static void Main(string[] args)
        {
            double velocidade;

            Console.Write("informe a velocidade do veiculo: ");
            velocidade = double.Parse(Console.ReadLine());

            Console.WriteLine("\nVelocidade do veiculo: " + velocidade + " Km/h");

            if (velocidade > 60)
            {
                Console.WriteLine("\nMultado por execosso de velocidade");
            }
            else
            {
                Console.WriteLine("\nvelocidade máxiam permitida");
            }

            Console.WriteLine("\nDirija sempre com o cinto de segurança");


            Console.ReadLine();
        }
    }
}
