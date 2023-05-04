using System;
using HogwartsPotions.Models.Entities;
using HogwartsPotions.Services;
using HogwartsPotions.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HogwartsPotions.Controllers
{
    [ApiController, Route("api/potions")]
    public class PotionController : ControllerBase
    {
        private readonly IPotionService _potionService;
        private readonly IStudentService _studentService;
        private readonly IRecipeService _recipeService;

        public PotionController(
            IPotionService potionService,
            IStudentService studentService,
            IRecipeService recipeService
        )
        {
            _potionService = potionService;
            _studentService = studentService;
            _recipeService = recipeService;
        }

        [HttpGet]
        public async Task<IEnumerable<Potion>> GetAllPotions()
        {
            return await _potionService.GetAllPotions();
        }

        [HttpGet("{studentId}")]
        public async Task<List<Potion>> GetStudentPotions(long studentId)
        {
            return await _potionService.GetStudentPotions(studentId);
        }


        [HttpPost("{studentId}")]
        public async Task<IActionResult> AddPotion(long studentId, [FromBody] Potion potionFromStudent)
        {
            throw new NotImplementedException();
        }

        [HttpPost("brew")]
        public async Task<IActionResult> StartNewPotion([FromBody] Student student)
        {
            throw new NotImplementedException();
        }
    }
}
