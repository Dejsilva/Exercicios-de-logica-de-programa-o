using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testes_logica
{
    class Par_ou_impar
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo...");
            Console.WriteLine("informe um numero para saber se é par ou ímpar");
            int numero = Convert.ToInt32(Console.ReadLine());
            int sobra = numero % 2;

            if (sobra == 0)
            {
                Console.WriteLine("Par: "+ numero);
            }
            else if (sobra == 1)
            {
                Console.WriteLine("Ímpar: " + numero);
            }
            else
            {
                Console.WriteLine("Dado inválido");
            }


                Console.ReadKey();
        }
    }
}
