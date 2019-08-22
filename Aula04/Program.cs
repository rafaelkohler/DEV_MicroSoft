using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[7] { 4, 5, 3, 5, 6, 8, 11 };
            var pares = from num in numbers where (num % 2) == 0 select num;
            var impares = from num in numbers where (num % 3) == 0 select num;

            Console.WriteLine("Numeros: ");
            foreach(int num in pares)
            {
                Console.Write(num + ", ");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Numeros divisiveis por 3: ");
            foreach (int num in impares)
            {
                Console.Write(num + ", ");
            }

            Console.WriteLine();
            Console.WriteLine();
            ExemploPessoa();

            Console.ReadKey();
        }

        static void ExemploPessoa()
        {
            Cidade vitoria = new Cidade()
            {
                Nome = "Vitoria"
            };

            Cidade curitiba = new Cidade()
            {
                Nome = "Curitiba"
            };

            IList<Pessoa> Pessoas = new List<Pessoa>();
            Pessoas.Add(new Pessoa()
            {
                Nome = "Rafael Kohler",
                Nascimento = new DateTime(1982, 03, 03),
                Cidade = curitiba
            });
            Pessoas.Add(new Pessoa()
            {
                Nome = "Lorena",
                Nascimento = new DateTime(1984, 09, 11),
                Cidade = vitoria
            });
            Pessoas.Add(new Pessoa()
            {
                Nome = "Charles",
                Nascimento = new DateTime(2009, 07, 26),
                Cidade = vitoria
            });
            Pessoas.Add(new Pessoa()
            {
                Nome = "Renan",
                Nascimento = new DateTime(2008, 02, 13),
                Cidade = curitiba
            });


            var resultado = from p in Pessoas orderby p.Nascimento ascending select p.Nome + " - Idade " + (DateTime.Now.Year - p.Nascimento.Year).ToString();

            

            foreach (var x in resultado)
            {
                Console.Write(x + ", ");
            }

            Console.WriteLine();

            var resultadoGroup = from p in Pessoas
                                 where DateTime.Now.Year - p.Nascimento.Year > 18 && DateTime.Now.Year - p.Nascimento.Year < 70
                                 group p by p.Cidade;
            

            foreach (var grupo in resultadoGroup)
            {
                Console.Write("\nInicio Grupo: " + grupo.Key.Nome + "\n");
                foreach(var item in grupo)
                {
                    
                        Console.Write(item.Nome + ", ");
                    
                    
                }
                Console.Write("\nFim Grupo: \n");
            }

            Console.WriteLine();
        }
    }
}
