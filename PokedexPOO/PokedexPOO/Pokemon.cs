using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexPOO
{
    public class Pokemon
    {
        public Pokemon()
        {
            this.Nome = "";
            this.Descricao = "";
        }

        public Pokemon(String nome, String descricao)
        {
            this.Nome = nome;
            this.Descricao = descricao;
        }

        private String nome;

        public String Nome
        {
            get { return nome;; }
            set 
            {
                String texto = value.ToUpper();
                nome = texto; 
            }
        }

        private String descricao; //armazena o valor da propriedade Descricao

        public String Descricao //representa a caracteristica Descricao do meu pokemon
        {
            get { return this.descricao; }
            set 
            { 
                this.descricao = value.ToUpper(); 
            }
        }

        public void ExibirDadosPokemon()
        {
            Console.WriteLine("Nome do Pokemon: " + this.Nome);
            Console.WriteLine("Descricao: " + this.Descricao);

        }

        public void ExibirDadosPokemon(Boolean formatado)
        {
            if (formatado)
            {
                Console.WriteLine("Pokémon: " + this.Nome + " " + this.Descricao.ToLower());
            }
            else
            {
            Console.WriteLine("Nome do Pokemon: " + this.Nome);
            Console.WriteLine("Descricao: " + this.Descricao);
            }
        }

    }
}
