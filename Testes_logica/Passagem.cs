using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testes_logica
{
    class Passagem
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo... A Companhia Aérea AA");
            Console.WriteLine("Temos passagens Ecônomicas, Executivas e Primeira Classe");
            Console.WriteLine("Informe o valor que gostaria de investir na passagem");
            Console.WriteLine("Para sabermos em que categoria você se encaixa");
            decimal valor_passagem = Convert.ToInt32(Console.ReadLine());

            if (valor_passagem <= 500)
            {
                Console.WriteLine("Categoria: Econômica");
            }
            else if (valor_passagem > 500 && valor_passagem <= 1500)
            {
                Console.WriteLine("Categoria: Executiva");
            }

            else
            {
                Console.WriteLine("Categoria: Primeira Classe");
            }

            Console.ReadKey();
        }    
    }

}
