using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double grausFahrenheit;
            double grausCelsius;

            Console.Write("Qual seu nome: ");
            nome = (Console.ReadLine());

            Console.WriteLine("\nOlá " + nome + " seja bem vindo(a)");

            Console.Write("\nDigite um valor em Fahrenheit: ");
            grausFahrenheit = double.Parse(Console.ReadLine());

            grausCelsius = 5 * ((grausFahrenheit - 32) / 9);

            Console.WriteLine("\n" + grausFahrenheit + " Graus em Fahrenheit é " + grausCelsius + " Graus em Celsius");


            Console.ReadLine();
          
        }
    }
}
