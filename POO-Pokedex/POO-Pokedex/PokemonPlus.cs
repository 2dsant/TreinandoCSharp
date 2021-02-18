using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Pokedex
{
    public class PokemonPlus:Pokemon
    {
        public PokemonPlus():base()
        {
            this.Poder = 0;
        }

        public PokemonPlus(String nome, String descricao, int poder):base(nome, descricao)
        {
            this.Poder = 0;
        }

        public int Poder { get; set; }
    }

}
