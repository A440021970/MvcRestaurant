using System.ComponentModel.DataAnnotations;

namespace MvcRestaurant.Models
{
    public class Platillo
    {
        public int Id { get; set; }
        public string? NombreDelPlatillo { get; set; }
        public int TiempoDePreparacion { get; set; }
        public string? Ingredientes { get; set; }
        public decimal Precio { get; set; }
    }
}
