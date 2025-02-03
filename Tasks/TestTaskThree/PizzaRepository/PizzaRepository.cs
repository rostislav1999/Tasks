using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PizzaApp.Models;

namespace PizzaApp.Repositories
{
    public class PizzaRepository
    {
        private readonly PizzaDBContext _context;

        public PizzaRepository(PizzaDBContext context)
        {
            _context = context;
        }

        // Синхронные методы
        public List<Pizza> GetAllPizzas() => _context.Pizzas.AsNoTracking().ToList();

        public Pizza GetPizzaById(int id)
        {
            return _context.Pizzas.AsNoTracking().FirstOrDefault(p => p.Id == id);
        }

        public Pizza FindById(int id)
        {
            return GetPizzaById(id);
        }

        // Асинхронные методы
        public async Task<List<Pizza>> GetAllPizzasAsync()
        {
            return await _context.Pizzas
                .AsNoTracking()
                .OrderBy(p => p.Id)
                .ToListAsync();
        }

        public async Task<Pizza> GetPizzaByIdAsync(int id)
        {
            return await _context.Pizzas
                .AsNoTracking()
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<Pizza> FindByIdAsync(int id)
        {
            return await GetPizzaByIdAsync(id);
        }
    }
}