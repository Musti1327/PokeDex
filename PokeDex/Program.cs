using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PokeDex
{
    internal class Program
    {
        static void Main(string[] args)
        {

            {
                Console.WriteLine("Velkommen til PokeDex");
                Console.WriteLine("1. Logind, 2. fortsæt uden Logind");
                Console.WriteLine("3. Afslut: ");

                var Valg = Console.ReadLine();

                LogindMethod logindMethod = new LogindMethod();
              
                Pokemon pokemon = new Pokemon();
                pokemon.Menu();               

                switch (Valg)
                {
                    case "1":
                        logindMethod.LogInd();
                        break;
                    case "2":
                        Console.WriteLine("Du er nu logget ind uden brug af logind");
                        break;
                        case "3":
                        Console.WriteLine("Programmet er afsluttet");
                        Console.ReadLine();
                        return;
                    default:
                        Console.WriteLine("Ugyldigt valg");
                        break;
                }
            }
        }
    }
}