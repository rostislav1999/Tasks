using Microsoft.EntityFrameworkCore;
using PizzaApp.Models;

namespace PizzaApp.Models
{
    public partial class PizzaDBContext : DbContext
    {
        public PizzaDBContext(DbContextOptions<PizzaDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Pizza> Pizzas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Конфигурация модели при необходимости
        }
    }
}