using System.ComponentModel.DataAnnotations;

namespace PadariaProj.Models
{
    public class Producao
    {
        [Key]
        public int Id { get; set; }
        public DateTime Data { get; set; } = DateTime.Now;
        public int QuantidadePaes { get; set; }
        public decimal FarinhaConsumida { get; set; }

        public List<IngredienteProducao> IngredientesUtilizados { get; set; } = new List<IngredienteProducao>();

    }
}
