using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testes_logica
{
    class Tabuada
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo");
            Console.WriteLine("Informe um numero");
            int numero = Convert.ToInt32(Console.ReadLine());
            int contador = 1;
            Console.Clear();

            while (contador <=10)
            {
                int resultado = contador * numero;
                Console.WriteLine(contador + " x " + numero + " = " + resultado);
                contador++;
            }

            Console.ReadKey();
        }
        

    }
}
