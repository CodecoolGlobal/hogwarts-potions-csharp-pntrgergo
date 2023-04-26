using System.Collections.Generic;
using System.Threading.Tasks;
using HogwartsPotions.Models.Entities;
using HogwartsPotions.Models.Enums;

namespace HogwartsPotions.Services.Interfaces;

public interface IPotionService
{
    Task<Potion> AddPotion(Potion potion);
    Task<Potion> MakeNewPotion(Student student);
    Task<Potion> GetPotionById(long potionId);
    Task<List<Potion>> GetAllPotions();
    Task<List<Potion>> GetStudentPotions(long studentId);
    Task<int> GetNumberOfPotionsByStudent(Student student);
    Task<bool> AddIngredientToPotion(Potion potionFromDb, Ingredient ingredient);
    Task AddRecipeToPotion(Potion potion, Recipe recipe);
}