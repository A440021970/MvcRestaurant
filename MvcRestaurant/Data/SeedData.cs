using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcRestaurant.Data;
using System;
using System.Linq;

namespace MvcRestaurant.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcRestaurantContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcRestaurantContext>>()))
            {
                // Look for any movies.
                if (context.Platillo.Any())
                {
                    return;   // DB has been seeded
                }

                context.Platillo.AddRange(
                    new Platillo
                    {
                        NombreDelPlatillo = "Enchiladas",
                        TiempoDePreparacion = 10,
                        Ingredientes = "tortilla, queso",
                        Precio = 50M
                    },

                    new Platillo
                    {
                        NombreDelPlatillo = "Chilaquiles",
                        TiempoDePreparacion = 5,
                        Ingredientes = "tortilla, queso, salsa, crema, frijoles, pollo",
                        Precio = 30M
                    },

                    new Platillo
                    {
                        NombreDelPlatillo = "Pizza de pepperoni",
                        TiempoDePreparacion = 30,
                        Ingredientes = "pan, queso, pepperoni",
                        Precio = 100M
                    },

                    new Platillo
                    {
                        NombreDelPlatillo = "Hamburguesa con papas",
                        TiempoDePreparacion = 15,
                        Ingredientes = "pan, carne, queso, mostaza, mayonesa, papas",
                        Precio = 50M
                    },

                    new Platillo
                    {
                        NombreDelPlatillo = "Cereal",
                        TiempoDePreparacion = 2,
                        Ingredientes = "cereal, leche",
                        Precio = 10M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}