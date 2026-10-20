using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Testes_logica
{
    class Listas_Array
    {
        static void Main(string[] args)
        {
            
            //out of range = erro em que indica que esta sendo acessada uma posição que não existe na matriz


            int numero = 0;
            string[] clientes = new string[4];

            while (numero < 4)
            {
                Console.WriteLine("Digite um nome de cliente: ");
                clientes[numero] = Console.ReadLine();

                numero++;
            }

            Console.Clear();

            foreach  (string lista_clientes in clientes)
            {
                Console.WriteLine(lista_clientes);
            }

            Console.ReadKey();

        }
    }
}