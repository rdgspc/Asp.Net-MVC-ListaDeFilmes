using Newtonsoft.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCFilmes.Models
{
    public class Filmes
    {
        public int Id { get; set; }
        [MaxLength(100)]
        [Required(ErrorMessage ="Este campo é obrigatório.")]
        [Display(Name = "Título")]
        public string Titulo { get; set; } = string.Empty;

        [Required(ErrorMessage = "Este campo é obrigatório.")]
        [Display(Name = "Data de Lançamento")]
        [DataType(DataType.Date)] 
        public DateTime DataLancamento { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório."), StringLength(10),]
        [Display(Name = "Gênero")]
        public string Genero { get; set; } = string.Empty;

        [Required(ErrorMessage = "Este campo é obrigatório.")]
        [Display(Name = "Preço")]
        [Column(TypeName = "decimal(18,2)")]
        [DataType(dataType: DataType.Currency)]
        public decimal Preco { get; set; }

        [Range(0,5, ErrorMessage ="Somente de 0 a 5")]
        [Required(ErrorMessage = "Este campo é obrigatório.")]
        public int? Pontos { get; set; } 
    }
}
