using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idades
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade1; int idade2; int idade3; int idade4; int idade5;
            int quantIdade;

            Console.Write("Digite a primeira idade: ");
            idade1 = int.Parse(Console.ReadLine());

            Console.Write("\nDigite a segunda idade: ");
            idade2 = int.Parse(Console.ReadLine());

            Console.Write("\nDigite a terceiar idade: ");
            idade3 = int.Parse(Console.ReadLine());

            Console.Write("\nDigite a quarta idade: ");
            idade4 = int.Parse(Console.ReadLine());

            Console.Write("\nDigite a quinta idade: ");
            idade5 = int.Parse(Console.ReadLine());

            quantIdade = (idade1 + idade2 + idade3 + idade4 + idade5) / 5;

            Console.WriteLine("\nA média das idades é: " + quantIdade);


            Console.ReadLine();
        }
    }
}
