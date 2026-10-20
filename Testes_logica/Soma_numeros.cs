using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testes_logica
{
    class Soma_numeros
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo...");
            Console.WriteLine("Informe numeros a serem somados");
       
            Console.WriteLine("Informe primeiro numero");
            int numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Segundo numero");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Terceiro numero");
            int numero3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Quarto numero");
            int numero4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Quinto numero");
            int numero5 = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            int soma = numero1 + numero2 + numero3 + numero4 + numero5;

            Console.WriteLine("Resultado: " + soma);

            Console.ReadKey();
        }
    }
}
