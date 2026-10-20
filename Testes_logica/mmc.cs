using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testes_logica
{
    class mmc
    {
        static void Main(string[] args)
        {
            string senha = "123456";
            Console.WriteLine("Informe sua senha para continuar");
           
            int tentativas = 0;
            while (tentativas < 3)
            {

                string sua_senha = Console.ReadLine();
               
                if (sua_senha != senha && tentativas < 2)
                    {
                    Console.WriteLine("Tente novamente : ");             
                    tentativas++;
                    }
                    else if (sua_senha == senha)
                {
                         Console.WriteLine("Bem vindo");
                         Console.WriteLine("Informe primeiro numero numero");

                         int numero1 = Convert.ToInt32(Console.ReadLine());

                         Console.WriteLine("Informe o segundo numero");

                        int numero2 = Convert.ToInt32(Console.ReadLine());
                        int contador1 = 2;
                        int contador2 = 2;
                        int[] divisor1 = new int[numero1];
                        int[] divisor2 = new int[numero2];
                        int contador_matriz = 0;
                        int contador_matriz2 = 0;
                        int[] matriz_final = new int[50];
                        int contador3 = 0;
                        int contador4 = 0;
                        int contador5 = 0;
                        int contador6 = 0;
                        int contador7 = 0;
                        int contador8 = 0;
                        int contador9 = 0;
                        int resultado_numero1 = 1;

                             while (numero1 != 1)
                                {
                                    int sobra = numero1 % contador1;
                                    if (sobra == 0)
                                    {
                                        numero1 = numero1 / contador1;
                                        divisor1[contador_matriz] = contador1;
                                        contador_matriz++;
                                        sobra = numero1 % contador1;

                                        if (sobra == 0)
                                        {
                                            numero1 = numero1 / contador1;
                                            divisor1[contador_matriz] = contador1;
                                            contador_matriz++;
                                        }
                                        else

                                        {
                                            contador1++;
                                        }
                                         }
                                        else
                                        {
                                            contador1++;
                                         }
                            }
                    while (numero2 != 1)
                    {
                        int sobra = numero2 % contador2;
                        if (sobra == 0)
                        {
                            numero2 = numero2 / contador2;
                            divisor2[contador_matriz2] = contador2;
                            contador_matriz2++;
                            sobra = numero2 % contador2;
                            if (sobra == 0)
                            {
                                numero2 = numero2 / contador2;
                                divisor2[contador_matriz2] = contador2;
                                contador_matriz2++;
                            }
                            else
                            {
                                contador2++;
                            }
                        }
                        else
                        {
                            contador2++;
                        }
                    }
                    Console.Clear();


                    while (divisor1[contador3] != 0)
                    {

                       
                        Console.WriteLine("matriz 1 numero :" + divisor1[contador3]);
                     
                        contador3++;

                    }
                    Console.WriteLine("========");
                    while (divisor2[contador4] != 0)
                    {
                        
                        Console.WriteLine("matriz 2 numero: " + divisor2[contador4]);
                       
                        contador4++;
                        

                    }
                    for (int i = 0; divisor1[i] != 0;  i++)
                    {
                        for (int c = 0; divisor2[c] != 0; c++)
                        {
                            if (divisor1[i] != divisor2[c])
                            {
                                matriz_final[contador5] = divisor2[c];
                                contador5++;
                            }
                            
                            
                        }
                    }

                    for (int i = 0; divisor2[i] != 0; i++)
                    {
                        for (int c = 0; divisor1[c]!= 0; c++)
                        {
                            if (divisor2[i] != divisor1[c])
                            {
                                matriz_final[contador5] = divisor1[c];
                                contador5++;
                            }
                          
                        }
                    }
                    /*
                    while (divisor1[contador5] != 0)
                    {
                        while (divisor2[contador6] != 0)
                        {
                            if (divisor1[contador5] != divisor2[contador6])
                            {
                                matriz_final[contador5] = divisor1[contador6];
                                contador5++;
                                contador6++;

                            }
                            else
                            {
                                contador6++;
                            }
                        }
                        contador5++;
                    }   

                      while (matriz_final[contador7] != 0)
                      {
                          while (divisor1[contador8] != 0)
                          {
                              if (matriz_final[contador7] != divisor2[contador8] )
                              {
                                  matriz_final[contador5] = divisor2[contador8];
                                  contador5++;
                                  contador8++;
                              }
                              else
                              {
                                  contador8++;
                              }
                          }
                          contador7++;
                      }

                    contador7 = 0; */

                    for (int i = 0; i < matriz_final.Length; i++)
                    {
                        if (matriz_final[i] != 0)
                        {
                            resultado_numero1 = resultado_numero1 * matriz_final[i];
                            Console.WriteLine("==" + matriz_final[i]);
                        }
                    }
                        
                    {
                        

                        Console.WriteLine("=========");
                        Console.WriteLine("MMC : " + resultado_numero1);

                    }
                    Console.WriteLine("Fim de programa");

                    tentativas = 4;

                }
                else
                {
                    Console.WriteLine("Acesso negado vacilão");
                    tentativas = 4;
                }
  
            }

            Console.ReadKey();

        }
    }
}
