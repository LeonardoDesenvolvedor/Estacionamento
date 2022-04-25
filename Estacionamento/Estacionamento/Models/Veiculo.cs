using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Estacionamento.Models
{

    [Table("tbl_veiculo")]
    public class Veiculo
    {
       
        [Key]
        public long? cod_veiculo { get; set; }

        [Required]
        [Column("nomeV", TypeName = "text")]
        public string Nome { get; set; }

        [Required]
        [Column("corV", TypeName = "text")]
        public string Cor { get; set; }

        [Required]
        [Column("modeloV", TypeName = "text")]
        public string Modelo { get; set; }

        [Required]
        [Column("placaV")]
        public string Placa { get; set; }

        [Required]
        [Column("combustivel", TypeName = "text")]
        public string TipoCombt { get; set; }



        // a tbl N de veiculo, recebe o 1 da tbl de proprieterio

        public long? cod_prop { get; set; }
        public Proprietario Proprietario { get; set; }
    }
}
