using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomandoDoisNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int result1, result2, result3, result4;

            Console.WriteLine("Somando dois valores");

            Console.Write("\nDigite o 1º valor: ");
            num1 = int.Parse(Console.ReadLine()); //recebe o valor digitado e armazena na variável.

            Console.Write("\nDigite 0 2º valor: ");
            num2 = int.Parse(Console.ReadLine()); 

            result1 = num1 + num2;
            result2 = num1 - num2;
            result3 = num1 * num2;
            result4 = num1 / num2;


            Console.WriteLine("\nO resultado da soma é: " + result1);
            Console.WriteLine("\nO resultado da subtração é: " + result2);
            Console.WriteLine("\nO resultado da multiplicação é: " + result3);
            Console.WriteLine("\nO resultado da divisão é: " + result4); // \n pula uma linha no corsole.


            Console.ReadLine();
        }
    }
}
