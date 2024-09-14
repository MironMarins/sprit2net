using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationCP2.Models
{
    [Table("LOJA")]
    public class Loja
    {
        [Key]
        public int IDLOJA { get; set; }

        [Required]
        public string NOMELOJA { get; set; }

        [Required]
        public int CNPJ {  get; set; }

        [Required]
        public string ENDERECO {  get; set; }
    }
}
