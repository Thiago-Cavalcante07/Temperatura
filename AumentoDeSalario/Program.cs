using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AumentoDeSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario;
            double novosalario;

            Console.WriteLine("Aumento de Salario");
         

            for (int i = 0; i < 0; i++)
            {
                Console.WriteLine("Informe o valor do salario: ");
                salario = double.Parse(Console.ReadLine());

                if (salario <= 1000)
                {
                    salario = salario * 1.50;
                }
                else
                {
                    salario = salario * 1.30;
                }

            }



            Console.ReadLine();
        }
    }
}
