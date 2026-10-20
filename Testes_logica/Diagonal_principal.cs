using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testes_logica
{
    class Diagonal_principal
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo......");
            int[,] numeros = new int[4, 4]
            {
                {45,65,98,12},
                {125,658,452,325},
                {845,565,215,225},
                {256,698,844,25}
            };
            int[] diagonal = new int[numeros.GetLength(0)];
            bool condicao = false;
            int contador = 0;
            int contador2 = 0;
            int soma = 0;

            for (int l = 0; l < numeros.GetLength(0); l++)
            {
                condicao = true;

                for (int c = 0; c < numeros.GetLength(1) || condicao != false; c++)
                {
                    if (condicao == true)
                    {
                        diagonal[contador] = numeros[l, contador2];
                        condicao = false;
                        contador++;
                        contador2++;
                    }
                }
             }

                foreach (var diagonais in diagonal)
                {
                    Console.WriteLine(diagonais);
                }

            for (int i = 0; i < diagonal.Length; i++)
            {
                soma = diagonal[i] + soma;
            }

            Console.WriteLine("resultado " + soma);
        }
    }
}
