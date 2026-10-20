using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testes_logica
{
    class Locadora
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo... A Locadora, Fulano de Tal");

            Console.WriteLine("Informe sua idade para continuarmos");
            int idade = Convert.ToInt32(Console.ReadLine());

            if (idade > 16)
            {
                Console.WriteLine("Podemos continuar para alugar");
            }
            else
            {
                Console.WriteLine("Não podemos continuar você é de menor");
            }

            Console.ReadKey();

        }
    }
}
