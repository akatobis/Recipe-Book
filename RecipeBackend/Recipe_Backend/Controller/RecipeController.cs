using Microsoft.AspNetCore.Mvc;
using Recipe_Backend.Aplication;
using Recipe_Backend.Aplication.Dto;
using Recipe_Backend.Aplication.Dto.CreateRecipeDto;
using Recipe_Backend.Aplication.Models;
using Recipe_Backend.Aplication.Repository;
using Recipe_Backend.Extensions;

namespace Recipe_Backend.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class RecipeController : ControllerBase
    {
        private readonly IRecipeRepository _recipeRepository;
        private readonly IUnitOfWork _unitOfWork;

        public RecipeController( 
            IRecipeRepository recipeRepository,
            IUnitOfWork unitOfWork )
        {
            _recipeRepository = recipeRepository;
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        [ProducesResponseType( typeof( RecipeDto ), 200 )]
        public IActionResult GetRecipe( int recipeId )
        {
            Recipe recipe = _recipeRepository.GetRecipeById( recipeId );
            if ( recipe == null )
            {
                return BadRequest( $"Not found recipe by id {recipeId}" );
            }

            return Ok( new RecipeDto(
                recipe.Title,
                recipe.Description,
                recipe.CookingTime,
                recipe.Portions,
                recipe.Image,
                recipe.RecipeIngredientsBlocks.ToDto(),
                recipe.RecipeSteps.ToDto(),
                recipe.RecipeLikes.ToDto(),
                recipe.RecipeFavourites.ToDto(),
                recipe.RecipeTags.ToDto()
            ));
        }

        [HttpPost]
        public IActionResult CreateRecipe( [FromBody] CreateRecipeDto recipe )
        {
            _recipeRepository.CreateRecipe( new Recipe(
                recipe.Title,
                recipe.Description,
                recipe.CookingTime,
                recipe.Portions,
                recipe.Image,
                recipe.RecipeIngredientsBlocks,
                recipe.RecipeSteps,
                recipe.RecipeLikes,
                recipe.RecipeFavourites,
                recipe.RecipeTags
            ));

            _unitOfWork.Commit();

            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteRecipe( int recipeId )
        {
            if ( _recipeRepository.GetRecipeById( recipeId ) == null )
            {
                return BadRequest( $"Not found recipe by id {recipeId}" );
            }

            _recipeRepository.DeleteRecipe( recipeId );

            _unitOfWork.Commit();

            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateRecipe( [FromBody] CreateRecipeDto recipe )
        {
            Recipe updateRecipe = _recipeRepository.GetRecipeById( recipe.RecipeId );
            if ( updateRecipe == null )
            {
                return BadRequest( $"Not found recipe by id {recipe.RecipeId}" );
            }

            updateRecipe.Title = recipe.Title;
            updateRecipe.Description = recipe.Description;
            updateRecipe.CookingTime = recipe.CookingTime;
            updateRecipe.Portions = recipe.Portions;
            updateRecipe.Image = recipe.Image;
            updateRecipe.RecipeFavourites = recipe.RecipeFavourites;
            updateRecipe.RecipeLikes = recipe.RecipeLikes;
            updateRecipe.RecipeIngredientsBlocks = recipe.RecipeIngredientsBlocks;
            updateRecipe.RecipeSteps = recipe.RecipeSteps;
            updateRecipe.RecipeTags = recipe.RecipeTags;

            _unitOfWork.Commit();

            return Ok();
        }
    }
}
