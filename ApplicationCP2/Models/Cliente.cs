using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationCP2.Models
{
    [Table("CLIENTE")]
    public class Cliente
    {
        [Key]
        public int IDCLIENTE { get; set; }
        
        [Required]
        public string NOME { get; set; }
        
        [Required]
        public string CPF { get; set; }

        [Required]
        public string RG { get; set; }

        [Required]
        public string LOGIN { get; set; }

        [Required]
        public string SENHA { get; set; }

        [Required]
        [Column(TypeName = "Date")]
        public DateTime DATANASCIMENTO { get; set; }

        [Required]
        public string EMAIL { get; set; }

        [Required]
        public string CONTATOS { get; set; }

        [Required]
        public string ENDERECO { get; set; }

        [Required]
        public string COMPRAS { get; set; }

    }
}
