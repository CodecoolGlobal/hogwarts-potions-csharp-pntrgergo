﻿using System.Collections.Generic;
using System.Threading.Tasks;
using HogwartsPotions.Models.Entities;

namespace HogwartsPotions.Services.Interfaces;

public interface IRecipeService
{
    Task AddRecipe(Recipe recipe);
    Task<List<Recipe>> GetAllRecipes();
    Task<int> GetNumberOfRecipesByStudent(Student student);
}
