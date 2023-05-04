using HogwartsPotions.Data;
using HogwartsPotions.Models.Entities;
using HogwartsPotions.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HogwartsPotions.Services
{
    public class RecipeService : IRecipeService
    {
        private readonly HogwartsContext _context;

        public RecipeService(HogwartsContext context)
        {
            _context = context;
        }
        public async Task AddRecipe(Recipe recipe)
        { 
            await _context.Recipes.AddAsync(recipe);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Recipe>> GetAllRecipes()
        {
            return await _context.Recipes.ToListAsync();
        }

        public async Task<int> GetNumberOfRecipesByStudent(Student student)
        {
            return await _context.Recipes.CountAsync(r => r.Student == student);
        }
    }
}
