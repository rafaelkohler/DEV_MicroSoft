﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORMEF
{
    public class Cidade
    {
        public int Id { get; set; }
        [Column("NOME_CIDADE")]
        [MaxLength(50, ErrorMessage="Cidade pode ter no maximo 50 caracteres")]
        [Required]
        public String Nome { get; set; }

        [InverseProperty("Cidade")]
        public IList<Pessoa> Moradores { get; set; }

        [InverseProperty("LocalNascimento")]
        public IList<Pessoa> PessoasNaturais { get; set; }
    }
}
