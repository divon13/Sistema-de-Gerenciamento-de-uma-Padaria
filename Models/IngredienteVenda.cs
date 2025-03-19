using System.ComponentModel.DataAnnotations;

namespace PadariaProj.Models
{
    public class IngredienteVenda
    {
        [Key]
        public int Id { get; set; }

        public int VendaId { get; set; }
        public Vendas Venda { get; set; }

        public int IngredienteId { get; set; }
        public Ingredientes Ingrediente { get; set; }

        public decimal QuantidadeUtilizada { get; set; } 
    }
}
