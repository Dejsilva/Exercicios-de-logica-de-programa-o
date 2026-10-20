using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testes_logica
{
    class Soma_coluna
    {
        static void Main(string[] args)
        {
            {

                Console.WriteLine("Bem vindo......");
                int[,] numeros = new int[3, 4]
                {
                {45,65,1,12},
                {1,5,285,3},
                {8,5,2,2},
                };

                int[] soma_colunas = new int[numeros.GetLength(1)];
                int numero = 0;

                for (int c = 0; c < numeros.GetLength(1); c++)
                {
                    int soma = 0;

                    for (int l = 0; l < numeros.GetLength(0); l++)
                    {

                        if (l < numeros.GetLength(1))
                        {
                            soma = soma + numeros[l, c];
                            soma_colunas[c] = soma;
                        }
                    }
                }
                foreach (var colunas in soma_colunas)
                {
                    Console.WriteLine(colunas);

                }
                numero = soma_colunas[0];

                for (int i = 0; i < soma_colunas.Length; i++)
                {
                    if (soma_colunas[i] <= numero)
                    {
                        numero = soma_colunas[i];
                       
                    }
                    
                   
                }
                Console.WriteLine("------------------");
                Console.WriteLine(numero);
            }
        }
    }
}
