using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhandocomSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            int tempo = 0;
            char escolha;

            inicio:

            Console.Clear();

            Console.WriteLine("Transportes disponíveis para ir trabalhar");
            Console.WriteLine("-=========================================");

            Console.WriteLine("\nEscolha o transporte: [m]Moto | [c]Carro | [o]Ônibus");
            escolha = char.Parse(Console.ReadLine());

            

            switch (escolha)
            {
                case 'm':
                case 'M':
                    tempo = 30;
                    break;
                case 'c':
                case 'C':
                    tempo = 50;
                    break;
                case 'o':
                case 'O':
                    tempo = 120;
                    break;
                default:
                    tempo = -1;
                    break;      
                    
            }

            if (tempo > 0)
            {
                Console.WriteLine("Com esse veiculo você leva {0}", tempo + " Minutos para chegar ao trabalho");
            }
            else
            {
                Console.WriteLine("Transporte indisponível");
            }

            Console.WriteLine("\nDeseja continuar com o programa: [s/n]");
            escolha = char.Parse(Console.ReadLine());

            

            if (escolha == 's' || escolha == 'S')
            {
                goto inicio;
            }
            else
            {
                Console.WriteLine("Fim do programa.");
            }

            Console.ReadLine();
        }
    }
}
