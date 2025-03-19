using System.ComponentModel.DataAnnotations;

namespace PadariaProj.Models
{
    public class Ingredientes
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        public decimal QuantidadeDisponivel { get; set; }

        public List<IngredienteVenda> IngredientesVendidos { get; set; } = new List<IngredienteVenda>();
    }
}
