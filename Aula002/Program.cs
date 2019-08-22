using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula002
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();

            p1.Nome = "Rafael";
            p1.Altura = 1.81;
            p1.Nascimento = new DateTime(2019, 12, 15);
            p1.Massa = 83;

            Livro l1 = new Livro();
            l1.Autores = new List<Pessoa>();
            l1.Autores.Add(p1);
            l1.Titulo = "C sharp";
            l1.Genero = "Tecnico";
            l1.NumeroPaginas = 200;
            l1.Editora = "FAEL";
            l1.ISBN = 2342231;

            Telefone telefone = new Telefone();

            telefone.Tocar();

            Console.ReadKey();
        }
    }
}
