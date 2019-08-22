using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula002
{
    class Livro
    {
        // <summary>
        /// Titulo ou nome do livro
        /// </summary>
        public String Titulo { get; set; }
        public int NumeroPaginas { get; set; }
        public int ISBN { get; set; }
        public List<Pessoa> Autores { get; set; }
        public String Genero { get; set; }
        public String Editora { get; set; }

        public List<Locacao> Locacoes { get; set; }
    }
}
