using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testes_logica
{
    class Contagem
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo...");
            Console.WriteLine("Infome um numero");
            int contador = Convert.ToInt32(Console.ReadLine());
            int numero = 1;
            Console.Clear();

            while ( numero <= contador)
            {   
                Console.WriteLine(numero);
                numero++;
            }

            Console.ReadKey();
        }
    }
}
