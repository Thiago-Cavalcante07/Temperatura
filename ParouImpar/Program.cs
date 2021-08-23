using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParouImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            int par;
            int imp;

            Console.WriteLine("Consulte se o número é Par ou Impar!!");

            Console.Write("\nDigite um número: ");
            par = int.Parse(Console.ReadLine());

            imp = par % 2;

            if (imp == 1)
            {
                Console.WriteLine("\nO número informado é Impar!!");
            }
            else
            {
                Console.WriteLine("\nO número informado é Par");
            }


            

            Console.ReadLine();
        }
    }
}
