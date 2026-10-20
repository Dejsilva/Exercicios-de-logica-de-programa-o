using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace Testes_logica
{
    class Aprovacao_Aluno
    {
        static void Main(string[] args)
        {
            string condicao = "SIM";
            string escolha = "SIM";
            List<string> alunos_aprovados = new List<string>();
            List<string> alunos_reprovados = new List<string>();
            Console.WriteLine("Bem vindo");
            Console.WriteLine("Para cadastra alunos aprovados e reprovados: ");

            while (condicao == escolha)
            {
                Console.WriteLine("Informe seu nome");
                string nome = Console.ReadLine();
                Console.WriteLine("Informe sua nota para saber se foi aprovado");

                int nota = Convert.ToInt32(Console.ReadLine());

                if (nota >= 7)
                {
                    Console.WriteLine("Parabens você foi aprovado");
                    alunos_aprovados.Add(nome);
                }
                else if (nota < 7)
                {
                    alunos_reprovados.Add(nome);
                    Console.WriteLine("Você foi reprovado");
                }

                else
                {
                    Console.WriteLine("Dado invalido");
                }

                Console.WriteLine("=============");
                Console.WriteLine("Se quiser cadastrando aluno, digite 'SIM'");
                escolha = Console.ReadLine();
                Console.Clear();
            }
            Console.Clear();
            foreach (var aprovados in alunos_aprovados)
            {
                Console.WriteLine("Aprovados : " + aprovados);
            }
            Console.WriteLine("===========");

            foreach ( var reprovados in alunos_reprovados)
            {
                Console.WriteLine("Reprovados: " + reprovados);
            }

            Console.ReadKey();
        }
    }
}
