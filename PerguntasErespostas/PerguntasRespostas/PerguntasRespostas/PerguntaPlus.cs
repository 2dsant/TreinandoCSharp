using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerguntasRespostas
{
    public class PerguntaPlus:Pergunta //Herança da classe pergunta
    {
        public PerguntaPlus():base() //Ele está pegando da classe base o construtor
        {
            this.Dica = "";
        }

        public PerguntaPlus(String texto, String resposta, String dica):base(texto, resposta) // Aqui é pego os parametros texto e resposta construtor base
        {
            this.Dica = dica;
        }

        public String Dica { get; set; }
    }
}
