using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ORMEF
{
    class Program
    {
        static void Main(string[] args)
        {
            ModelPessoas context = new ModelPessoas();
            Pessoa p = new Pessoa()
            {
                Nome = "Rafael Kohler",
                Nascimento = new DateTime(1982, 03, 03)
            };

            Pessoa p2 = new Pessoa()
            {
                Nome = "Lorena Furuzawa",
                Nascimento = new DateTime(1984, 09, 11)
            };

            Pessoa resultado = PersistirPessoa(context, p);
            Pessoa resultadoP2 = PersistirPessoa(context, p2);

            Cidade curitiba = null;
            curitiba = (from c in context.Cidades
                        .Include(c => c.Moradores)
                        where c.Nome == "Curitiba"
                        select c).FirstOrDefault();

            if (curitiba == null)
            {
                curitiba = new Cidade { Nome = "Curitiba" };
            }

            resultado.Cidade = curitiba;
            resultadoP2.Cidade = curitiba;

            context.SaveChanges();

            foreach (Pessoa pessoa in curitiba.Moradores)
            {
                Console.WriteLine("Nome: " + pessoa.Nome);
            }

            Casa casa = new Casa()
            {
                Cidade = curitiba,
                Endereco = "Rua XXXXXXX, N.123, Bairro: 000",

            };


            casa.Moradores.Add(resultado);
            casa.Moradores.Add(resultadoP2);

            context.Casas.Add(casa);

            context.SaveChanges();
            Console.ReadKey();
        }

        private static Pessoa PersistirPessoa(ModelPessoas context, Pessoa p)
        {
            if (context.Pessoas.Where(item =>
            item.Nome == p.Nome).Count()
            == 0)
            {
                context.Pessoas.Add(p);
            }

            var resultado = (from pessoa in context.Pessoas
                             where pessoa.Nome == p.Nome
                             select pessoa).FirstOrDefault();

            if (resultado == null)
            {
                resultado = context.Pessoas.Add(p);
            }

            return resultado;
        }
    }
}
