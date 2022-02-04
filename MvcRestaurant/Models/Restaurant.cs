using System.ComponentModel.DataAnnotations;

namespace MvcRestaurant.Models
{
    public class Restaurant
    {
        public int idMenu { get; set; }
        public string? NombreDelPlatillo { get; set; }

        [DataType(DataType.Date)]
        public TimeOnly TiempoDePreparacion { get; set; }
        public string? Ingredientes { get; set; }
        public decimal Precio { get; set; }
    }
}
