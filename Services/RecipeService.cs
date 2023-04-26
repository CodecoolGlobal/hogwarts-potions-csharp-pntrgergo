using HogwartsPotions.Models.Entities;
using HogwartsPotions.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HogwartsPotions.Services
{
    public class RecipeService : IRecipeService
    {
        public Task AddRecipeToDb(Recipe recipe)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<Recipe>> GetAllRecipes()
        {
            throw new System.NotImplementedException();
        }

        public Task<int> GetNumberOfRecipesByStudent(Student student)
        {
            throw new System.NotImplementedException();
        }

        public Task<Recipe> GetRecipeByIngredients(HashSet<Ingredient> ingredients)
        {
            throw new System.NotImplementedException();
        }
    }
}
