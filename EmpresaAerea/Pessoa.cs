using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaAerea
{
    [Table("PESSOAS")]
    public class Pessoa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(100)]
        public String Nome { get; set; }

        [Required]
        public String Sobrenome { get; set; }

        [Required]
        public String Documento { get; set; }

        public DateTime DataNascimento { get; set; }

        [Required]
        public String TelefoneContato { get; set; }

        public IList<Passagem> Passagens { get; set; }
    }
}
