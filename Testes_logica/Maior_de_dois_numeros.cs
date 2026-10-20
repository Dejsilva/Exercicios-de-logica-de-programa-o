using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testes_logica
{
    class Maior_de_dois_numeros
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo");
            Console.WriteLine("Informe o primeiro numero");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o segundo numero");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            if(numero1 > numero2)
            {
                Console.WriteLine(numero1 + " é maior que " + numero2);
            }
            else if (numero2 > numero1)
            {
                Console.WriteLine(numero2 + " é maior que " + numero1);
            }

            else if(numero1 == numero2)
            {
                Console.WriteLine("os numeros são iguais");
            }

            else
            {
                Console.WriteLine("Informe um dado valido");
            }


            Console.ReadKey();
        }
    }
}
