using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testes_logica
{
    class Numero_Secreto
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo");

            Random randon = new Random();
            int numero_sorteado = randon.Next(1,10);
            Console.WriteLine("Tente acertar o numero sorteado");
            Console.WriteLine("Informe um numero de 1 a 10");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero == numero_sorteado) Console.WriteLine("Parabens acertou de primeira");


            while (numero != numero_sorteado)
            {

                Console.WriteLine("Tente novamente:");
             numero = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

            }
            Console.WriteLine("Parabens Você acertou");

           

        }
    }
}
