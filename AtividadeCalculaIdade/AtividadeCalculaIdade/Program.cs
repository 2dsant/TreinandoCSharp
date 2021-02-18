using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeCalculaIdade
{
    class Program
    {
        static void Main(string[] args)
        {

            Pessoa p1;
            Pessoa p2;
            Pessoa p3;

            Console.WriteLine("Determina qual é a pessoa mais velha");
            //Leitura de Dados da primeira pessoa
            Console.WriteLine("Nome da pessoa 01: ");
            p1 = new Pessoa();
            p1.Nome = Console.ReadLine();
            Console.WriteLine("Idade da pessoa 01: ");
            p1.Idade = Convert.ToInt32(Console.ReadLine());

            //Leitura de Dados da segunda pessoa
            Console.WriteLine("Nome da pessoa 02: ");
            p2 = new Pessoa();
            p2.Nome = Console.ReadLine();
            Console.WriteLine("Idade da pessoa 02: ");
            p2.Idade = Convert.ToInt32(Console.ReadLine());

            //Leitura de Dados da terceira pessoa
            Console.WriteLine("Nome da pessoa 03: ");
            String nome = Console.ReadLine();
            Console.WriteLine("Idade da pessoa 03: ");
            int idade = Convert.ToInt32(Console.ReadLine());
            p3 = new Pessoa(nome, idade);

            //Lógica
            if ((p1.Idade > p2.Idade) && (p1.Idade > p3.Idade))
            {
                Console.WriteLine("A pessoa mais velha é: ");
                p1.ExibirDados();
            }
            else if ((p2.Idade > p3.Idade) && (p2.Idade > p1.Idade))
            {
                Console.WriteLine("A pessoa mais velha é: ");
                p2.ExibirDados();
            }
            else if ((p3.Idade > p1.Idade) && (p3.Idade > p2.Idade))
            {
                Console.WriteLine("A pessoa mais velha é: ");
                p3.ExibirDados();
            }
            else
            {
                Console.WriteLine("Todas as pessoas possuem a mesma idade");
            }

            Console.ReadKey();
        }
    }
}
