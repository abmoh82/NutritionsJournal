using DailyNutrition.Models;
using Microsoft.EntityFrameworkCore;

namespace DailyNutrition.DataContext
{
    public class DailyNutritionContext : DbContext
    {
        public DailyNutritionContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Schema> Schemas { get; set; }
    }
}
