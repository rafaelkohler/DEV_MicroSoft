using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adivinhador
{
    class Program
    {
        static void Main(string[] args)
        {
            Random sorteador = new Random();
            int valor = sorteador.Next(100);

            Boolean acertou = false;

            do
            {
                Console.WriteLine("Digite um valor inteiro de 0 a 100 ");
                String valorLido = Console.ReadLine();
                int valor1 = int.Parse(valorLido);

                if (valor1 < valor)
                {
                    Console.WriteLine("O valor digitado e menor que o valor sorteado.");
                }
                else if (valor1 > valor)
                {
                    Console.WriteLine("O valor digitado e maior que o valor sorteado.");
                }
                else
                {
                    Console.WriteLine("Voce acertou. " + valor);
                }
            } while (!acertou);

            Console.ReadLine();
        }
    }
}
