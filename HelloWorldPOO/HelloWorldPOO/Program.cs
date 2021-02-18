using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Mensagem msg1;
            msg1 = new Mensagem();
            msg1.TextoMensagem = "Alo Mundo";
            msg1.ExibirMensagem();
            //msg1.TextoMensagem = "Hello World";
            //Console.WriteLine(msg1.getTextoMensagem());
            //msg1.ExibirMensagem();



            Console.ReadKey();
        }
    }
}
