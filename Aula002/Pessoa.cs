using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula002
{
    public class Pessoa
    {
        private String _Nome;
        public double Altura { get; set; }
        public DateTime Nascimento { get; set; }
        public double Massa { get; set; }

        public String Nome
        {
            get { return _Nome; }
            set { _Nome = value; }
        }

        public List<Locacao> Locacoes { get; set; }
    }
}
