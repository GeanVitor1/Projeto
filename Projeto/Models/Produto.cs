using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto.Models
{
    public class Produto
    {
        [Key]
        public int IdProduto { get; set; }
        
        [Required(ErrorMessage ="o campo {0} é de preenchimento obrigatorio")]
        [MaxLength(100)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "o campo {0} é de preenchimento obrigatorio")]
        [MaxLength(10000)]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "o campo {0} é de preenchimento obrigatorio")]
        [MaxLength(100)]
        public string Autor { get; set; }


        [Required(ErrorMessage = "o campo {0} é de preenchimento obrigatorio")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Preco { get; set; }


        [Required(ErrorMessage = "o campo {0} é de preenchimento obrigatorio")]
        public int Estoque { get; set; }
    }
}
