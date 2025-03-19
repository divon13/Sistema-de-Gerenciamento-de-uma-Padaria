using System.ComponentModel.DataAnnotations;

namespace PadariaProj.Models
{
    public class Vendas
    {
        [Key]
        public int Id { get; set; }
        public DateTime Data { get; set; } = DateTime.Now;
        [Required]
        public string TipoPagamento { get; set; } 
        public decimal ValorTotal { get; set; }

        public List<IngredienteVenda> IngredientesVendidos { get; set; } = new List<IngredienteVenda>();
    }
}
