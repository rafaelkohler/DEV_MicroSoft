using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaAerea
{
    [Table("VOOS")]
    public class Voo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public DateTime InicioPrevisto { get; set; }

        public DateTime InicioReal { get; set; }

        [Required]
        public DateTime ChegadaPrevista { get; set; }

        public DateTime ChegadaReal { get; set; }

        public IList<Poltrona> Poltronas { get; set; }

        [Required]
        [InverseProperty("Partidas")]
        public Cidade Origem { get; set; }

        [Required]
        [InverseProperty("Chegadas")]
        public Cidade Destino { get; set; }

        [InverseProperty("Voos")]
        public Aviao Aviao { get; set; }
    }
}
