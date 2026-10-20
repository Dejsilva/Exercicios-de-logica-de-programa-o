using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testes_logica
{
    class Transportadora
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo... A Transportadora SS");

            Console.WriteLine("Vamos calcular o valor da entrega");
            Console.WriteLine("Entregas até 10kg saem por R$20");
            Console.WriteLine("Entregas acima de 10kg saem por 50kg");
            Console.WriteLine("Informe o peso da sua entrega");
            decimal peso = Convert.ToDecimal(Console.ReadLine());
            decimal valor_entrega = 0;

            if (peso <= 10)
            {
                valor_entrega = peso * 20;
            }

            else if (peso > 10 )
            {
                valor_entrega = peso * 50; 
            }

            else
            {
                Console.WriteLine("Dado invalido");
            }

            valor_entrega.ToString("00,00");

            Console.WriteLine("Valor da Entrega: " + "R$" + valor_entrega);

            Console.ReadKey();
        }
    }
}
