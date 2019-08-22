using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaAerea
{
    [Table("POLTRONAS")]
    public class Poltrona
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int Coluna { get; set; }

        public int Fileira { get; set; }

        public Pessoa Passageiro { get; set; }

        public Voo Voo { get; set; }
    }
}
