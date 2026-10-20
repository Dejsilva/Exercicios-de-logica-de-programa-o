using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testes_logica
{
    class Pares_Intervalos
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo");
            Console.WriteLine("Para visualização de pares");
            Console.WriteLine("Informe um numero de inicio");
            int inicio = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe um numero final");
            int final = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("numeros pares");

            while (inicio <= final)
            {
                int sobra = inicio % 2;

                if (sobra == 0)
                {
                    Console.WriteLine(inicio);
                }

                inicio++;
            }

            Console.ReadKey();
        }
    }
}
