using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaAerea
{
    [Table("PASSAGENS")]
    public class Passagem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public String Bilhete { get; set; }

        public IList<Voo> Trechos { get; set; }

        [Required]
        [InverseProperty("Passagens")]
        public Pessoa Passageiro { get; set; }

        [Required]
        public FormaPagamento Pagamento { get; set; }

        [Required]
        public Cidade Origem { get; set; }

        [Required]
        public Cidade Destino { get; set; }

        public IList<Poltrona> Poltronas { get; set; }
    }
}
