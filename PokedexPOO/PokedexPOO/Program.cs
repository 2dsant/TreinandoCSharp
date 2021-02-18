using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokedex pokedex = new Pokedex();
            int resp = 100;

            while (resp != 0)
            {
                resp = Menu();
                if(resp == 1)
                {
                    pokedex.ListarPokemons();
                }
                Console.ReadKey();
                Console.Clear();
            }
        }

        static int Menu()
        {
            Console.WriteLine("Pokedéx - Agenda Pokémon");
            Console.WriteLine("0 - Sair da Pokedéx ");
            Console.WriteLine("1 - Listar Pokemons");
            Console.WriteLine("O que você deseja fazer: ");

            int resp = Convert.ToInt32(Console.ReadLine());
            return resp;
        }
    }
}
