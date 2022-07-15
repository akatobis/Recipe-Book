using Microsoft.AspNetCore.Mvc;
using RecipeBook.Application;
using RecipeBook.Application.Dto;
using RecipeBook.Application.Dto.CreateRecipeDto;
using RecipeBook.Application.Dto.GetRecipeDto;
using RecipeBook.Application.Dto.GetRecipesDto;
using RecipeBook.Application.Dto.UpdateRecipeDto;
using RecipeBook.Application.Models;
using RecipeBook.Application.RepositoriesInterfaces;
using RecipeBook.Extensions;

namespace RecipeBook.Controller
{
    [ApiController]
    [Route( "/api" )]
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

        [HttpGet( "recipe/{recipeId}" )]
        public IActionResult GetRecipe( [FromRoute] int recipeId )
        {
            Recipe recipe = _recipeRepository.GetRecipeById( recipeId );
            if ( recipe == null )
            {
                return BadRequest( $"Not found recipe by id {recipeId}" );
            }

            return Ok( new GetRecipeDto(
                recipe.Title,
                recipe.Description,
                recipe.CookingTime,
                recipe.Portions,
                recipe.Image,
                recipe.RecipeIngredientsBlocks.ToDto(),
                recipe.RecipeSteps.ToDto(),
                recipe.RecipeTags.ToDto(),
                recipe.RecipeLikesCount,
                recipe.RecipeFavouritesCount
            ) );
        }

        [HttpGet( "add-recipe/{recipeId}" )]
        public IActionResult GetUpdateRecipe( [FromRoute] int recipeId )
        {
            Recipe recipe = _recipeRepository.GetRecipeById( recipeId );
            if ( recipe == null )
            {
                return BadRequest( $"Not found recipe by id {recipeId}" );
            }

            return Ok( new GetRecipeDto(
                recipe.Title,
                recipe.Description,
                recipe.CookingTime,
                recipe.Portions,
                recipe.Image,
                recipe.RecipeIngredientsBlocks.ToDto(),
                recipe.RecipeSteps.ToDto(),
                recipe.RecipeTags.ToDto(),
                recipe.RecipeLikesCount,
                recipe.RecipeFavouritesCount
            ) );
        }

        [HttpGet( "main" )]
        public IActionResult GetRecipeOfDay()
        {
            Recipe recipe = _recipeRepository.GetRecipeOfDay();

            return Ok( new RecipeOfDayDto(
                recipe.RecipeId,
                recipe.Title,
                recipe.Description,
                recipe.Image,
                recipe.CookingTime,
                recipe.RecipeLikesCount
           ) );
        }

        [HttpGet( "recipes" )]
        public IActionResult GetRecipes( int skip, string search )
        {
            Recipe[] recipes = _recipeRepository.GetRecipes( skip, search );

            List<GetRecipesDto> recipesDto = new( 5 );

            if ( recipes.Length == 0 )
            {
                return BadRequest( "Recipes not found" );
            }

            foreach ( Recipe recipe in recipes )
            {
                GetRecipesDto recipeDto = new(
                    recipe.RecipeId,
                    recipe.Title,
                    recipe.Description,
                    recipe.CookingTime,
                    recipe.Portions,
                    recipe.Image,
                    recipe.RecipeTags.ToDto(),
                    recipe.RecipeFavouritesCount,
                    recipe.RecipeLikesCount
                );

                recipesDto.Add( recipeDto );
            }

            return Ok( recipesDto );
        }

        [HttpPost( "add-recipe" )]
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
                recipe.RecipeTags,
                recipe.RecipeFavouritesCount,
                recipe.RecipeLikesCount
            ) );

            _unitOfWork.Commit();

            return Ok();
        }

        [HttpDelete( "recipe/{recipeId}" )]
        public IActionResult DeleteRecipe( [FromRoute] int recipeId )
        {
            if ( _recipeRepository.GetRecipeById( recipeId ) == null )
            {
                return BadRequest( $"Not found recipe by id {recipeId}" );
            }

            _recipeRepository.DeleteRecipe( recipeId );

            _unitOfWork.Commit();

            return Ok();
        }

        [HttpPut( "add-recipe/{recipe.RecipeId}" )]
        public IActionResult UpdateRecipe( [FromBody] UpdateRecipeDto recipe )
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
            updateRecipe.RecipeFavouritesCount = recipe.RecipeFavouritesCount;
            updateRecipe.RecipeLikesCount = recipe.RecipeLikesCount;
            updateRecipe.RecipeIngredientsBlocks = recipe.RecipeIngredientsBlocks;
            updateRecipe.RecipeSteps = recipe.RecipeSteps;
            updateRecipe.RecipeTags = recipe.RecipeTags;

            _unitOfWork.Commit();

            return Ok();
        }
    }
}
