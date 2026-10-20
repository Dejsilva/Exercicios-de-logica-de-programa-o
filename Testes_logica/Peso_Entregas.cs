using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testes_logica
{
    class Peso_Entregas
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo...");
            Console.WriteLine("Informe o peso das entregas");
            int contador = 1;
            decimal peso = 0;
            decimal peso_total = 0;
     



            while (contador < 6)
            {

                
               peso = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Peso" + contador + ": " + peso);
                peso_total = peso + peso_total;
                contador++;
            }

            Console.Clear();
            Console.WriteLine("peso total: " + peso_total);

            Console.ReadKey();

        }
    }
}
