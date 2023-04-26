using System.Collections.Generic;
using System.Threading.Tasks;
using HogwartsPotions.Models.Entities;

namespace HogwartsPotions.Services.Interfaces;

public interface IRecipeService
{
    Task AddRecipeToDb(Recipe recipe);
    Task<List<Recipe>> GetAllRecipes();
    Task<Recipe> GetRecipeByIngredients(HashSet<Ingredient> ingredients);
    Task<int> GetNumberOfRecipesByStudent(Student student);
}
