using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Testes_logica
{
    class Faixa_Etaria
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo...");
      
            List<string> adultos = new List<string>();
            List<string> Crianca = new List<string>();
            List<string> adolescente = new List<string>();
            
            string condicao = "SIM";
            string escolha = "SIM";


            while (condicao == escolha)
            {
                Console.WriteLine("Informe seu nome");
                string nome = Console.ReadLine();
                Console.WriteLine("Para sabermos qual sua faixa etária informe sua idade");
                int idade = Convert.ToInt32(Console.ReadLine());
                if (idade > 0 && idade <= 12)
                {
                    Crianca.Add(nome);
                }
                else if (idade >= 13 && idade <= 17)
                {
                    adolescente.Add(nome);
                }
                else if (idade >= 18)
                {
                    adultos.Add(nome);
                }
                else
                {
                    Console.WriteLine("Informe um dado valido");
                }

                Console.WriteLine("se quiser continuar digite: 'SIM'");
                escolha = Console.ReadLine();

                Console.Clear();
            }
            Console.Clear();

            Console.WriteLine("Crianças:");
            foreach (var kids in Crianca)
            {
                Console.WriteLine(kids);
            }
            Console.WriteLine("==============");

            Console.WriteLine("adultos:");
            foreach (var adults in adultos)
            {
              Console.WriteLine(adults);
            }
            Console.WriteLine("==============");

            Console.WriteLine("Adolescentes:");
            foreach (var teenagers in adolescente)  
            {
                
                Console.WriteLine(teenagers);
            }

            Console.ReadKey();
        }
    }
}
