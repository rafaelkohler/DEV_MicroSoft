using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaAerea
{
    [Table("FORMA_PAGAMENTOS")]
    public class FormaPagamento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public String Forma { get; set; }

        public Decimal Valor { get; set; }

        public DateTime DataPagamento { get; set; }

        public Passagem Passagem { get; set; }
    }
}
