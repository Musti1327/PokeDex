using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace PokeDex
{
    public class Pokemon
    {
        private string filepath = @"C:\Users\shahm\Desktop\PokeMon\PokeMon.txt";

        public List<string> Pokemons = new List<string> {"id:1, Name: pikachu, type:ligtning, styrke:10", "id:2, Name:charmander, type:fire, styrke:8", "id:3, Name:bulbasaur, type:grass, styrke:7"};
        
        public void Menu()
        {
                while(true)
                {
                Console.Clear();
                Console.WriteLine("1. Tilføj pokemon: ");
                Console.WriteLine("2. Opdater pokemon: ");
                Console.WriteLine("3. Vis alle pokemon: ");
                Console.WriteLine("4. Slet pokemon: ");

                var Valg = Console.ReadLine();
                
                switch (Valg)
                {
                    case "1":
                        AddPokemon();
                        break;
                    case "2":
                        UpdatePokemon();
                        break;
                    case "3":
                        ShowAllPokemon();
                        break;
                    case "4":
                        DeletePokemon();
                        break;
                    default:
                        Console.WriteLine("Ugyldigt valg");
                        break;
                }

            }

        


        }
        public void AddPokemon()
        {
            int id;
            Console.WriteLine("Du kan tilføje 3 pokemons");
            for(int i = 0; i < Pokemons.Count; i++)
            {
                Console.WriteLine(Pokemons[i]);
            }
            Console.WriteLine("Indtast id for den pokemon du ville tilføje: ");
            id = Convert.ToInt32(Console.ReadLine());

            switch(id)
            {
                case 1:
                    id--;
                    using (var writer = new StreamWriter(filepath, true))
                    {
                        writer.WriteLine(Pokemons[id]);
                    }
                    break;
                case 2:
                    id--;
                    using (var writer = new StreamWriter(filepath, true))
                    {
                        writer.WriteLine(Pokemons[id]);
                    }
                    break;
                case 3:
                    id--;
                    using (var writer = new StreamWriter(filepath, true))
                    {
                        writer.WriteLine(Pokemons[id]);
                    }
                    break;
            }
        }

        public void DeletePokemon()
        {
            using (StreamReader reader = new StreamReader(filepath))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }

            Console.WriteLine("Du kan slette 3 pokemons");
            Console.WriteLine("Indtast id for den pokemon du ville slette: ");
           
            string? pokemonId = Console.ReadLine();
            var selectedPokemon = Pokemons.FirstOrDefault(p => p.StartsWith("id:"+ pokemonId+","));
            if (selectedPokemon != null)
            {
                var lines = File.ReadAllLines(filepath).ToList();
                lines.Remove(selectedPokemon);
                File.WriteAllLines(filepath, lines);
                Console.WriteLine("Pokemon er slettet");
            }
            else
            {
                Console.WriteLine("Pokemon ikke fundet");
            }
    
        }

        public void UpdatePokemon()
        {
            using (StreamReader reader = new StreamReader(filepath))
            {
            string? line;
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
            }

            Console.WriteLine("Du kan opdatere 3 pokemons");
            Console.WriteLine("Indtast id for den pokemon du ville opdatere: ");
            string? pokemonId = Console.ReadLine();
            var lines = File.ReadAllLines(filepath).ToList();
            var selectedPokemon = lines.FindIndex(p => p.StartsWith("id:"+ pokemonId+","));
            if (selectedPokemon != null)
            {
                Console.WriteLine("Indtast ny styrke for pokemon: ");
                string? newStyrke = Console.ReadLine();
                Console.WriteLine("Indtast ny type for pokemon: ");	
                string? newType = Console.ReadLine();
                Console.WriteLine("Indtast nyt navn for pokemon: ");
                string? newName = Console.ReadLine();

                lines[selectedPokemon] = $"id:{pokemonId}, Name:{newName}, type:{newType}, styrke:{newStyrke}";
                File.WriteAllLines(filepath, lines);
                Console.WriteLine("Pokemon er opdateret");

            }
            else
            {
                Console.WriteLine("Pokemon ikke fundet");
            }
            Console.ReadLine();
        }

        public void ShowAllPokemon()
        {
            using (var reader = new StreamReader(filepath))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            Console.ReadLine();
        }
    }
}


