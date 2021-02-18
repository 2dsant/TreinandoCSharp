using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerguntasRespostas
{
    class Program
    {
        static void Main(string[] args)
        {
            PerguntaPlus p = new PerguntaPlus();
            p.Texto = "Qual o nome do animal que tem o pescoço enorme?";
            p.Resposta = "girafa";
            p.Dica = "É amarelo";

            Console.WriteLine("Tente adivinhar a pergunta");
            Console.WriteLine("Pergunta: " + p.Texto);
            Console.WriteLine("Dica: " + p.Dica);
            Console.WriteLine("Resposta: ");
            String resposta = Console.ReadLine();

            if (p.Resposta.ToUpper() == resposta.ToUpper())
            {
                Console.WriteLine("Parabéns! Você acertou");
            } else
            {
                Console.WriteLine("Resposta incorreta");
            }
            Console.ReadKey();
        }
    }
}
