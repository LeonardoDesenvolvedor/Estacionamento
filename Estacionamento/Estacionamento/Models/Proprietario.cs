using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Estacionamento.Models
{
    [Table("tbl_proprietario")]
    public class Proprietario
    {
        [Key]
        public long? cod_prop { get; set; }

        [Required]
        [Column("nome", TypeName = "text")]
        [MaxLength(15)]
        public string Nome { get; set; }

        [Required]
        [Column("sobrenome", TypeName = "text")]
        [MaxLength(35)]
        public string SobreNome { get; set; }

        [Column("rg")]
        [Required]
        [MaxLength(9)]
        public string Rg { get; set; }

        [Column("cpf")]
        [Required]
        [MaxLength(11)]
        public string Cpf { get; set; }

        [Column("data_Nasc")]
        public DateTime AnoNasc { get; set; }

        [Required]
        [Column("cnh_categoria")]
        public string CategoriaCnh { get; set; }

        // implementacao de multiplicidade e navegabilidade 
        public virtual ICollection<Veiculo> Veiculos { get; set; }
    }
}