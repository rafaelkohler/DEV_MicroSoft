using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula002
{
    class Locacao
    {
        public DateTime DataEmprestimo { get; set; }
        public DateTime DataDevolucao { get; set; }
        public Pessoa Locatario { get; set; }
        public Livro Livro { get; set; }
    }
}
