using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexPOO
{
    public class Pokedex
    {
        public Pokedex()
        {
            this.InicializarLista();
        }

        private List<Pokemon> pokemons;

        public List<Pokemon> Pokemons
        {
            get { return pokemons; }
        }


        private void InicializarLista()
        {
            //Instanciar a lista
            this.pokemons = new List<Pokemon>();

            //inserção de dados
            Pokemon p = new Pokemon("Bulbassauro", "Pokemon do tipo planta/venenoso");
            this.pokemons.Add(p);

            p = new Pokemon("Bulbassauro", "Pokemon do tipo planta/venenoso");
            this.pokemons.Add(p);

            p = new Pokemon("Pikachu", "Pokemon do tipo elétrico");
            this.pokemons.Add(p);

            p = new Pokemon("Cartepie", "Pokemon do tipo inseto/venenoso");
            this.pokemons.Add(p);

            p = new Pokemon("Mew", "Pokemon do tipo psiquico/lendário");
            this.pokemons.Add(p);

            p = new Pokemon("Mewtho", "Pokemon do tipo psquico/lendário");
            this.pokemons.Add(p);

            p = new Pokemon("Charizard", "Pokemon do tipo aereo/dragao/fogo");
            this.pokemons.Add(p);

            p = new Pokemon("Piplup", "Pokemon do tipo água");
            this.pokemons.Add(p);

            p = new Pokemon("Charmander", "Pokemon do tipo dragão/fogo");
            this.pokemons.Add(p);

            p = new Pokemon("Madikarp", "Pokemon do tipo água");
            this.pokemons.Add(p);

            p = new Pokemon("Chicorita", "Pokemon do tipo planta");
            this.pokemons.Add(p);

            p = new Pokemon("Gengar", "Pokemon do tipo fantasma");
            this.pokemons.Add(p);
        }
        public void ListarPokemons()
        {
            for (int i = 0; i < this.Pokemons.Count; i++)
            {
                this.Pokemons[i].ExibirDadosPokemon();
                //Pokemon p = this.Pokemons[i];
                //p.ExibirDadosPokemon();
            }
        }
    }
}
