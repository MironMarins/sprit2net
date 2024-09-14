using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationCP2.Models
{
    [Table("PRODUTO")]
    public class Produto
    {
        [Key]
        public int IDPRODUTO { get; set; }

        [Required]
        public string NOME { get; set; }

        [Required]
        public string DESCRICAO { get; set; }

        [Required]
        public int QUANTIDADEESTOQUE { get; set; }

        [Required]
        public string CATEGORIA { get; set; }

        [Required]
        public double VALOR { get; set; }

        [Required]
        [Column(TypeName = "Date")]
        public DateTime DATACADASTRO { get; set; }
    }
}
