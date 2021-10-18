using Microsoft.EntityFrameworkCore;
using DailyNutrition.Models;

namespace DailyNutrition.Data
{
    public class DailyNutritionContext : DbContext
    {
        public DailyNutritionContext(DbContextOptions<DailyNutritionContext> options)
            : base(options)
        {
        }

        public DbSet<Breakfast> Breakfast { get; set; }

        public DbSet<Lunch> Lunch { get; set; }

        public DbSet<Dinner> Dinner { get; set; }

        public DbSet<Snacks> Snacks { get; set; }
    }
}
