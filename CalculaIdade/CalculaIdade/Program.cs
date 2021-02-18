using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcula a idade de uma pessoa");

            Console.WriteLine("Digite o seu nome:");
            string nome = Console.ReadLine(); 
            Console.WriteLine("Digite o ano do seu nascimento:");
            int ano = Convert.ToInt32(Console.ReadLine());

            Pessoa p;
            p = new Pessoa(nome, ano);

            p.ExibirDados();

            Console.ReadKey();
        }
    }
}
