using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PokeDex
{
    public class LogindMethod
    {
        private string? brugernavn;
        private string? password;

        public void LogInd()
        {
            Console.WriteLine("Indtast brugernavn:");
            brugernavn = Console.ReadLine();
            Console.WriteLine("Indtast password:");
            password = Console.ReadLine();

            using (var reader = new StreamReader(@"C:\Users\shahm\Desktop\Logind\Users.txt"))
            {
                string? line;
                bool isAuthenticated = false;

                while ((line = reader.ReadLine()) != null)
                {
                    var credentials = line.Split(',');
                    if (credentials[0] == brugernavn && credentials[1] == password)
                    {
                        isAuthenticated = true;
                        break;
                    }
                }

                if (isAuthenticated)
                {
                    Console.WriteLine("Login successful!");
                    Pokemon pokemon = new Pokemon();
                    pokemon.Menu();
                }

                else
                {
                    Console.WriteLine("Invalid username or password.");
                }
            }
        }
    }
}