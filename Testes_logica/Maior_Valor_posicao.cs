using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testes_logica
{
    class Maior_Valor_posicao
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo......");
            int[,] numeros = new int[3, 4]
            {
                {45,65,98,12},
                {125,658,452,325},
                {845,565,215,225},
            };

            int numero = 0;
            int linha = 0;
            int coluna = 0;

            for (int l = 0; l < numeros.GetLength(0); l++)
            {
                for (int c = 0; c < numeros.GetLength(1); c++)
                {
                                 
                    if (numeros[l,c] > numero)
                    {
                        numero = numeros[l, c];
                        linha = l;
                        coluna = c;
                    }
                }
            }

            Console.WriteLine("linha " + linha + " coluna " + coluna + " numero: "+ numero);

            Console.ReadKey();
        }
    }
}
