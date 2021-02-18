using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldPOO
{
    public class Mensagem
    {
        //private string TextoMensagem;

        //public void ExibirMensagem()
        //{
        //    Console.WriteLine(TextoMensagem);
        //}

        //public string getTextoMensagem()
        //{
        //    return this.TextoMensagem;
        //}

        //public void setTextoMensamge(String valor)
        //{
        //    this.TextoMensagem = valor.ToUpper();
        //}

        private String textoMensagem;
        public String TextoMensagem
        {
            get
            {
                return this.textoMensagem;
            }

            set
            {
                this.textoMensagem = value.ToUpper();
            }
        }

        public void ExibirMensagem()
        {
            Console.WriteLine(this.TextoMensagem);
        }
    }
}
