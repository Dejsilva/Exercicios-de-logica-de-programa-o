using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Testes_logica
{
    class excluir_matriz
    {
        static void Main(string[] args)
        {
            int contador = 0;
            string condicao = "SIM";
            string escolha = "SIM";
            string escolha2 = "SIM";
            string opcoes = "";

            Console.WriteLine("Olá, Bem vindo");
            Console.WriteLine("Cadastro de funcionarios");
            Console.WriteLine("Escolha o numero de usuarios que gostaria de cadastrar");
            int numero = Convert.ToInt32(Console.ReadLine());
            string[] nome = new string[numero];
            string nome_excluido = "";
            

            for (int i = 0; i < nome.Length; i++)
            {
                Console.WriteLine("Informe o nome");

                nome[i] = Console.ReadLine();
            }
            Console.WriteLine("=============");

            for (int i = 0; i < nome.Length; i++)
            {
                Console.WriteLine(nome[i]);
            }

            Console.WriteLine("=============");

            
            while (escolha2 == "SIM")
            {
                Console.WriteLine("OPÇÕES digite o numero  oqual gostaria");
                Console.WriteLine("1 : excluir");
                Console.WriteLine("2 : cadastrar");
                Console.WriteLine("digite qualquer coisa para encerrar");
                opcoes = Console.ReadLine();


                if (opcoes == "1")
                {
                    for (int i = 0; i < nome.Length && escolha == condicao; i++)
                    {
                        Console.WriteLine("Escreva o nome que quer excluir");
                        nome_excluido = Console.ReadLine();

                        Console.WriteLine("===========");

                        for (int c = 0; c < nome.Length; c++)
                        {
                            if (nome_excluido == nome[c])
                            {
                                nome[c] = null;

                            }

                            Console.Clear();
                            //else if (nome_excluido != nome[c])
                            //{
                            // Console.WriteLine("não encontamos o nome este nome");

                            // }
                        }
                        Console.WriteLine("===========");

                        foreach (var nomes in nome)
                        {
                            if (nomes != null)
                            {
                                Console.WriteLine(nomes);
                            }

                        }

                        Console.WriteLine("===========");
                        Console.WriteLine("Se quiser excluir mais alguem digite 'SIM'");
                        escolha = Console.ReadLine();

                    }
                }

                else if (opcoes == "2")
                     
                {
                    Console.Clear();

                    for (int i = 0; i < nome.Length && condicao == escolha2; i++)
                    {
                        if (nome[i] == null)
                        {
                            nome[i] = Console.ReadLine();

                            foreach (var nomes in nome)
                            {
                                Console.WriteLine(nomes);
                            }

                            Console.WriteLine("Digite SIM para continuar cadastrando");
                            escolha = Console.ReadLine();
                        }
                        else if (nome.Length == numero)
                        {
  
                           Console.WriteLine("Digite o nome que gostaria de cadastrar");

         
                            foreach (var nomes in nome)
                            {
                                Console.WriteLine(nomes);
                            }
                            Console.WriteLine("Digite SIM para continuar cadastrando");

                            opcoes = Console.ReadLine();
                        }
                    }

                    Console.WriteLine("nomes cadastrados");
                    foreach (var nomes in nome)
                    {

                        Console.WriteLine(nomes);
                    }
                }

                Console.WriteLine("=============");

                Console.WriteLine("Se quiser continuar digite SIM");
                escolha = Console.ReadLine();

            }
        }
    }
}



