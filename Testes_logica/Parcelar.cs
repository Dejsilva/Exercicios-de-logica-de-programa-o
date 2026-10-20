using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testes_logica
{
    class Parcelar
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo...");
            Console.WriteLine("Digite o valor que gostaria de parcelar");
            decimal valor = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Valor das parcelas");
            int contador = 1;
            decimal valor_parcela = 0;

            valor_parcela.ToString();

            while (contador < 11)
            {
              
                valor_parcela = valor / contador;
                Console.WriteLine(contador + "x" + "=" + valor_parcela);
               

                contador++;
            }

            Console.ReadKey();

        }

    }
}
