using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;


namespace AvaliacaoEstagio.Models
{
   /// <summary>
   /// Tabela Usuario
   /// </summary>
    [Table("tbUsuario")]
    public partial class tbUsuario
    {
        [Key]
        public int IdUsuario { get; private set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Email { get; set; }

        public DateTime DataDeNascimento { get; set; }

        [Required]
        [StringLength(20)]
        public string Senha { get; set; }

    }
}
