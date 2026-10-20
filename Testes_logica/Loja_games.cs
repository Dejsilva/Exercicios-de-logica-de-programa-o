using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testes_logica
{
    class Loja_games
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo... A Loja de Games HH");
            Console.WriteLine("Estamos com a promção que todos jogos estão R$100");
            Console.WriteLine("Se for liente VIP tem 20% de desconto");
            Console.WriteLine("Informe seu nome para sabermos se é um cliente Vip");
            string nome = Console.ReadLine();
            Console.Clear();
            int preco = 100;

            if (nome == "Deivide" || nome == "Joana" || nome == "Silvia" && nome == "Pedro" && nome == "Rodolpho")
            {
                preco = 100 - 20;
                Console.WriteLine("Parabens você é um clinte ViP");
            }
            else 
            {
                Console.WriteLine("Você não é um cliente VIP");
            }

            Console.WriteLine("O jogo sai por: " + "R$" + preco);

            Console.ReadKey();
        }
    }
}
