using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaisDeOrigem
{
    class Program
    {
        static void Main(string[] args)
        {

            string pais;
            string nacionalidade;
            string paisNovo;
            string nacionalidadeNova;
            int resposta = -1;

            Dictionary<string, string> dicPaisNacionalidade = new Dictionary<string, string>();

            // inicializar alguns valores no dicionário...
            dicPaisNacionalidade.Add("brasil", "brasileiro");
            dicPaisNacionalidade.Add("estados unidos", "americano");
            dicPaisNacionalidade.Add("china", "chinês");
            dicPaisNacionalidade.Add("jamaica", "jamaicano");

            while(resposta != 3)
            {
                
                Console.Write("\nEscolha o que deseja fazer: ");
                Console.Write("\n1. Informar seu país de origem: ");
                Console.Write("\n2. Inserir novo país e nacionalidade: ");
                Console.Write("\n3. Sair ");

                resposta = int.Parse(Console.ReadLine());

                switch (resposta)
                {
                    case 1: // quer informar país e saber a nacionalidade
                        {
                            Console.WriteLine("\nVamos conhecer a sua Nascionalidade!!!");
                            Console.WriteLine("\nPaíses disponíveis: \n");

                            foreach (var item in dicPaisNacionalidade)
                            {
                                Console.WriteLine(item.Key);
                            }
                            Console.Write("\nInforme seu país de origem: ");
                            pais = Console.ReadLine();
                            while (!dicPaisNacionalidade.ContainsKey(pais))
                            {
                                Console.WriteLine("\nPaís não encontrado.");
                                Console.Write("\nInforme seu país de origem: digite sair para encerrar");

                                pais = (Console.ReadLine());
                                if (pais == "sair") break;
                            }

                            if (pais != "sair")
                            {
                                Console.WriteLine("\nAtualmente você está residindo no(a) " + pais);

                                Console.WriteLine(
                                        "\nSua nacionalidade é:  " + dicPaisNacionalidade[pais]);
                            }
                            break;
                        };
                    case 2:
                        {
                            Console.WriteLine("Você deseja inserir país e nacionalidade.");
                            Console.Write("Digite o país: ");
                            paisNovo = (Console.ReadLine());
                            Console.Write("Digite a nacionalidade: ");
                            nacionalidadeNova = (Console.ReadLine());
                            dicPaisNacionalidade.Add(paisNovo, nacionalidadeNova);
                            break;
                        };
                    case 3:
                        {
                            break;
                        };

                    default:
                        break;
                }

                if (resposta == 3) break;



                
            }

            Console.WriteLine("Saindo...");


            
 
            
            
            
            

            

            //openWith.Add("Brasil", "Brasileiro");

            //Console.WriteLine("For key = \"Brasil\", value = {0}.",openWith["Brasileiro"]);

            /*
            if (pais == nacionalidade || pais == nacional)
            {
                Console.WriteLine("\nVocê mora no " + nacionalidade + " você é Brasileiro!!!");
            }
            else
            {
                Console.WriteLine("\nVocê não mora no " + nacionalidade + " você é estrangeiro");
            }
            */

            Console.ReadLine();
        }
    }
}
