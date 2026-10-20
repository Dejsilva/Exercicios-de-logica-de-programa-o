using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Testes_logica
{
    class Soma_por_linha
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bem vindo......");
            int[,] numeros = new int[3, 4]
            {
                {4555,65,98,12},
                {17777,658,452,325},
                {845,565,215,225},
            };

            int[] soma_linhas = new int[numeros.GetLength(0)];
            int numero = 0;
           

            for (int l = 0; l < numeros.GetLength(0); l++)
            {
                int soma = 0;

                for (int c = 0; c < numeros.GetLength(1); c++)
                {
                  
                    if (c < numeros.GetLength(1))
                    {
                        soma = soma + numeros[l, c];
                        soma_linhas[l] = soma;
                    }
                }
            }

            for (int i = 0; i < soma_linhas.Length; i++)
            {
  
                    for (int c = 0; c < soma_linhas.Length; c++)
                    {
                        if(soma_linhas[i] > numero)
                        {
                        numero = soma_linhas[i];
                        }
                    }
             
            }

            foreach (var resultados in soma_linhas)
            {
                Console.WriteLine(resultados);

            }
            Console.WriteLine("Menor numero : " + numero);

            Console.ReadKey();
        }
    }
}
