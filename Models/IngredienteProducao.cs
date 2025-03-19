using System.ComponentModel.DataAnnotations;

namespace PadariaProj.Models
{
    public class IngredienteProducao
    {
        [Key]
        public int Id { get; set; }

        public int ProducaoId { get; set; }
        public Producao Producao { get; set; }

        public int IngredienteId { get; set; }
        public Ingredientes Ingrediente { get; set; }

        public decimal QuantidadeUsada { get; set; }
    }
}
