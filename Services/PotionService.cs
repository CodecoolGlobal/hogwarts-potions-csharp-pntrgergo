using HogwartsPotions.Models.Entities;
using HogwartsPotions.Models.Enums;
using HogwartsPotions.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
using HogwartsPotions.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HogwartsPotions.Services
{
    public class PotionService : IPotionService
    {

        private const int MaxIngredientsForPotions = 5;
        private readonly HogwartsContext _context;

        public PotionService(HogwartsContext context)
        {
            _context = context;
        }

        public async Task<bool> AddIngredientToPotion(Potion potionFromDb, Ingredient ingredient)
        {
            Ingredient fetchedIngredient = await FetchIngredient(ingredient);

            if (potionFromDb.Ingredients.Count < MaxIngredientsForPotions)
            {
                if (ingredient is not null)
                {
                    potionFromDb.Ingredients.Add(fetchedIngredient);
                }
                else
                {
                    potionFromDb.Ingredients.Add(fetchedIngredient);
                }

                _context.Potions.Update(potionFromDb);
                await _context.SaveChangesAsync();
                return true;
            }

            return false;
        }


        public async Task<Potion> AddPotion(Potion potion)
        {
             Potion receivedPotion = _context.Potions.Add(potion).Entity;
             await _context.SaveChangesAsync();

             return receivedPotion;
        }

        public async Task AddRecipeToPotion(Potion potion, Recipe recipe)
        {
            potion.Recipe = recipe;
            _context.Potions.Update(potion);
            await _context.SaveChangesAsync(); ;
        }

        public async Task<List<Potion>> GetAllPotions()
        {
            return await _context.Potions.ToListAsync();
        }

        public async Task<int> GetNumberOfPotionsByStudent(Student student)
        {
            return await _context.Potions.CountAsync(p => p.Student == student);
        }

        public async Task<Potion> GetPotionById(long potionId)
        {
            return await _context.Potions.FirstOrDefaultAsync(p => p.Id == potionId);
        }

        public async Task<List<Potion>> GetStudentPotions(long studentId)
        {
            return await _context.Potions.Where(p => p.Student.Id == studentId).ToListAsync();
        }

        public async Task<Potion> MakeNewPotion(Student student)
        {
            Potion potion = new Potion(
                name: $"{student.Name}'s discovery",
                student: student,
                brewingStatus: BrewingStatus.Brew,
                    recipe: null);
            return await AddPotion(potion);
        }

        private async Task<Ingredient> FetchIngredient(Ingredient studentsIngredient)
        {
            return await _context.Ingredients.Where(i => i.Name == studentsIngredient.Name).FirstOrDefaultAsync();
        }
    }

}




