using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhandocomQuociente
{
    class Program
    {
        static void Main(string[] args)
        {
            int divid, divis, quoci, rest;
            char escolha;

            inicio:

            Console.Clear();

            Console.WriteLine("\nMostrando o Quociente e o Resto de um número");
            Console.WriteLine("==============================================");

            Console.Write("\nDigite um valor para ser o dividendo: ");
            divid = int.Parse(Console.ReadLine());

            Console.Write("\nDigite um valor para ser o divisor: ");
            divis = int.Parse(Console.ReadLine());


            try
            {
                quoci = dividi(divid, divis, out rest);
                Console.WriteLine("\n{0} / {1} = quociente {2}, resto =  {3}", divid, divis, quoci, rest);
                //throw new Exception("ERRO do throw ");
            }
            catch(Exception e)
            {
                Console.WriteLine("\n" + e.Message);
                Console.WriteLine("[ERRO] Informe um valor diferente de [0]");

            }
            finally
            {
                Console.WriteLine("\nFim do processo...");
            }
            

            Console.WriteLine("\nDeseja continuar com o programa: [s/n]");
            escolha = char.Parse(Console.ReadLine());

            if (escolha == 's' || escolha == 'S')
            {
                goto inicio;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Fim do programa");
            }

            Console.ReadLine();
        }

        static int dividi(int dividendo, int divisor, out int resto)
        {
            int quociente = dividendo / divisor;
            resto = dividendo % divisor;
            return quociente;
        }

    }
}
