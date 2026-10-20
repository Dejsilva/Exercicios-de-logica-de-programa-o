using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testes_logica
{
    class mmc_com_List
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo");

            Console.WriteLine("Informe primeiro numero numero");
            int numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o segundo numero");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            List<int> divisor1 = new List<int>();
            List<int> divisor2 = new List<int>();
            List<int> divisores_ambos = new List<int>();
            int contador1 = 2;
            
            while(numero1 != 1)
            {
                int sobra = numero1 % contador1;
                if (sobra == 0)
                {
                    numero1 = numero1 / contador1;
                    divisor1.Add(contador1);
                    sobra = numero1 % contador1;

                    if (sobra == 0)
                    {
                        numero1 = numero1 / contador1;
                        divisor1.Add(contador1);
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

            contador1 = 2;

            while (numero2 != 1)
            {
                int sobra = numero2 % contador1;
                if (sobra == 0)
                {
                    numero2 = numero2 / contador1;
                    divisor2.Add(contador1);
                    sobra = numero2 % contador1;

                    if (sobra == 0)
                    {
                        numero2 = numero2 / contador1;
                        divisor2.Add(contador1);
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
            Console.Clear();

            foreach (var dividores1 in divisor1)
            {
                Console.WriteLine(dividores1);
            }
            Console.WriteLine("========");

            foreach (var divisores2 in divisor2)
            {
                Console.WriteLine(divisores2);  
            }

            contador1 = 0;
            int contador2 =  0;

            while (contador1 < divisor1.Count)
            {
                if (divisor1[contador2] != divisor2[contador1])
                {
                    divisores_ambos.Add(divisor1[contador2]);
                    contador2++;
                }

                contador1++;
            }

            contador1 = 0;
            contador2 = 0;

            while (contador1 < divisor2.Count)
            {
                if (divisor2[contador2] != divisor1[contador1])
                {
                    divisores_ambos.Add(divisor2[contador2]);
                    contador2++;
                }

                contador1++;
            }

            Console.WriteLine("Lista Final ===");
            foreach (var ambos in divisores_ambos)
            {
                Console.WriteLine(ambos);
            }
        }
    }
}
