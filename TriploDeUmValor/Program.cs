using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriploDeUmValor
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, triplo;

            Console.WriteLine("\nConsulte o triplo de um valor");

            Console.Write("\nInforme um valor: ");
            num = int.Parse(Console.ReadLine());

            triplo = num * 3;

            Console.WriteLine("\nO triplo desse valor é: "+ triplo);


            Console.ReadLine();
        }
    }
}
