using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Pokedex
{
    public class Pokedex
    {
        public Pokedex()
        {
            this.InicializarLista();
        }

        private List<PokemonPlus> pokemons;

        public List<PokemonPlus> Pokemons
        {
            get { return pokemons; }
        }


        private void InicializarLista()
        {
            //Instanciar a lista
            this.pokemons = new List<PokemonPlus>();

            //inserção de dados
            PokemonPlus p = new PokemonPlus("Bulbassauro", "Pokemon do tipo planta/venenoso");
            this.pokemons.Add(p);

            p = new PokemonPlus("Bulbassauro", "Pokemon do tipo planta/venenoso");
            this.pokemons.Add(p);

            p = new PokemonPlus("Pikachu", "Pokemon do tipo elétrico");
            this.pokemons.Add(p);

            p = new PokemonPlus("Cartepie", "Pokemon do tipo inseto/venenoso");
            this.pokemons.Add(p);

            p = new PokemonPlus("Mew", "Pokemon do tipo psiquico/lendário");
            this.pokemons.Add(p);

            p = new PokemonPlus("Mewtho", "Pokemon do tipo psquico/lendário");
            this.pokemons.Add(p);

            p = new PokemonPlus("Charizard", "Pokemon do tipo aereo/dragao/fogo");
            this.pokemons.Add(p);

            p = new PokemonPlus("Piplup", "Pokemon do tipo água");
            this.pokemons.Add(p);

            p = new PokemonPlus("Charmander", "Pokemon do tipo dragão/fogo");
            this.pokemons.Add(p);

            p = new PokemonPlus("Madikarp", "Pokemon do tipo água");
            this.pokemons.Add(p);

            p = new PokemonPlus("Chicorita", "Pokemon do tipo planta");
            this.pokemons.Add(p);

            p = new PokemonPlus("Gengar", "Pokemon do tipo fantasma");
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
