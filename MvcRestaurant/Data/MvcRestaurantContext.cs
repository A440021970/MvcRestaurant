#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcRestaurant.Models;

namespace MvcRestaurant.Data
{
    public class MvcRestaurantContext : DbContext
    {
        public MvcRestaurantContext (DbContextOptions<MvcRestaurantContext> options)
            : base(options)
        {
        }

        public DbSet<MvcRestaurant.Models.Platillo> Platillo { get; set; }
    }
}
