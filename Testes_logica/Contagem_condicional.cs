using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testes_logica
{
    class Contagem_condicional
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo......");
            int[,] numeros = new int[3, 4]
            {
                {45,5,98,12},
                {125,658,5,325},
                {845,565,5,225},
            };
            Console.WriteLine("digite o numero quer comparar");
            int numero = Convert.ToInt32(Console.ReadLine());
            int maiores = 0;
            int menores = 0;
            int iguais = 0;


            for (int l = 0; l < numeros.GetLength(0); l++)
            {
                for (int c = 0; c < numeros.GetLength(1); c++)
                {
                    if (numeros[l,c] > numero)
                    {
                        maiores++;
                    }
                    else if (numeros[l,c] < numero)
                    {
                        menores++;
                    }
                    else if (numeros[l,c] == numero)
                    {
                        iguais++;
                    }
                }
            }

            Console.WriteLine("Quantidade numeros maiores que " + numero + " : " + maiores);
            Console.WriteLine("Quantidade numeros menores que " + numero + " : " + menores);
            Console.WriteLine("Quantidade numeros iguais a " + numero + " : " + iguais);
        }
    }
}
