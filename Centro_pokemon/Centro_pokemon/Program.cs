using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Centro_pokemon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            while (opcao != 6)  // != == diferente
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine(@"
██████╗░░█████╗░██╗░░██╗███████╗███╗░░░███╗░█████╗░███╗░░██╗
██╔══██╗██╔══██╗██║░██╔╝██╔════╝████╗░████║██╔══██╗████╗░██║
██████╔╝██║░░██║█████═╝░█████╗░░██╔████╔██║██║░░██║██╔██╗██║
██╔═══╝░██║░░██║██╔═██╗░██╔══╝░░██║╚██╔╝██║██║░░██║██║╚████║
██║░░░░░╚█████╔╝██║░╚██╗███████╗██║░╚═╝░██║╚█████╔╝██║░╚███║
╚═╝░░░░░░╚════╝░╚═╝░░╚═╝╚══════╝╚═╝░░░░░╚═╝░╚════╝░╚═╝░░╚══╝ ");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("\n 1 - Cadastro de Pokémon");
                Console.WriteLine("\n 2 - Cadastro de Polebolas");
                Console.WriteLine("\n 3 - Cadastro de Treinadores");
                Console.WriteLine("\n 4 - Cadastro de Cidade");
                Console.WriteLine("\n 5 - Cadastro de Ginásios");
                Console.WriteLine("\n 6 - Sair");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n \n Digite a opção escolhida: ");
                Console.ResetColor();
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        cadastropokemon();
                        break;
                    case 2:
                        pokebolas();
                        break;
                    case 3:
                        break;
                    case 4:
                        ;
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Opção Inválida. Digite outro dígito.");
                        Console.ResetColor();
                        Thread.Sleep(2000); // 2000 MILISEGUNDOS = 2seg
                        break;





                }
            }
        }
        static void cadastropokemon()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\n Nome do Pokémon: ");
            string nomepokemon = Console.ReadLine();
            Console.WriteLine("\n Status do Pokémon: ");
            string statuspokemon = Console.ReadLine();
            Console.WriteLine("\n Quantidade de Golpes do Pokémon.");
            int qtdgolpes = int.Parse(Console.ReadLine());
            for (int i = 1; i <= qtdgolpes; i++)
            {
                Console.WriteLine($"\n {i} golpe do Pokémon: ");
                string golpepokemon = Console.ReadLine();
            }

            Console.WriteLine("\n Evoluções que o Pokémon tem: ");
            int qtdevo = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtdevo; i++)
            {
                Console.WriteLine($"\n {i} evolução do Pokémon: ");
                string nomeevo = Console.ReadLine();
            }
            Console.WriteLine("\n Elemento do Pokémon: ");
            string elem = Console.ReadLine();
            Console.WriteLine("\n Quantas fraquezas seu Pokémon tem: ");
            int qtdfraq = int.Parse(Console.ReadLine());
            for (int i = 1; i <= qtdfraq; i++)
            {
                Console.WriteLine($"\n {i} fraqueza do Pokémon: ");
                string fraq = Console.ReadLine();
            }
            Console.WriteLine("Raridade do Pokémon: ");
            string raridade = Console.ReadLine();
            Console.WriteLine("Peso do Pokémon: ");
            string peso = Console.ReadLine();
        }


        static void pokebolas()
        {

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine(@"
██████╗░░█████╗░██╗░░██╗███████╗██████╗░░█████╗░██╗░░░░░░█████╗░░██████╗
██╔══██╗██╔══██╗██║░██╔╝██╔════╝██╔══██╗██╔══██╗██║░░░░░██╔══██╗██╔════╝
██████╔╝██║░░██║█████═╝░█████╗░░██████╦╝██║░░██║██║░░░░░███████║╚█████╗░
██╔═══╝░██║░░██║██╔═██╗░██╔══╝░░██╔══██╗██║░░██║██║░░░░░██╔══██║░╚═══██╗
██║░░░░░╚█████╔╝██║░╚██╗███████╗██████╦╝╚█████╔╝███████╗██║░░██║██████╔╝
╚═╝░░░░░░╚════╝░╚═╝░░╚═╝╚══════╝╚═════╝░░╚════╝░╚══════╝╚═╝░░╚═╝╚═════╝░");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkBlue;


        }
    }
}
