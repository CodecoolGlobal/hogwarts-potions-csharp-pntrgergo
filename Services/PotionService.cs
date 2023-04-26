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

        public Task<List<Potion>> GetAllPotions()
        {
            throw new System.NotImplementedException();
        }

        public Task<int> GetNumberOfPotionsByStudent(Student student)
        {
            throw new System.NotImplementedException();
        }

        public Task<Potion> GetPotionById(long potionId)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<Potion>> GetStudentPotions(long studentId)
        {
            throw new System.NotImplementedException();
        }

        public Task<Potion> MakeNewPotion(Student student)
        {
            throw new System.NotImplementedException();
        }

        //

        private async Task<Ingredient> FetchIngredient(Ingredient studentsIngredient)
        {
            return await _context.Ingredients.Where(i => i.Name == studentsIngredient.Name).FirstOrDefaultAsync();
        }
    }

}




