using RecipeBook.Application.Dto;
using RecipeBook.Application.Dto.GetRecipeDto;
using RecipeBook.Application.Models;

namespace RecipeBook.Extensions
{
    public static class ConvertionExtensions
    {
        public static List<RecipeStepDto> ToDto( this IEnumerable<RecipeStep> recipeSteps )
        {
            return recipeSteps.Select( s => s.ToDto() ).ToList();
        }

        public static RecipeStepDto ToDto( this RecipeStep step )
        {
            return new RecipeStepDto
            {
                Number = step.Number,
                Description = step.Description
            };
        }

        public static List<RecipeTagDto> ToDto( this IEnumerable<RecipeTag> recipeTags )
        {
            return recipeTags.Select( s => s.ToDto() ).ToList();
        }

        public static RecipeTagDto ToDto( this RecipeTag tag )
        {
            return new RecipeTagDto
            {
                Name = tag.Name
            };
        }

        public static List<RecipeIngredientsBlockDto> ToDto( this IEnumerable<RecipeIngredientsBlock> recipeParts )
        {
            return recipeParts.Select( s => s.ToDto() ).ToList();
        }

        public static RecipeIngredientsBlockDto ToDto( this RecipeIngredientsBlock part )
        {
            return new RecipeIngredientsBlockDto
            {
                Name = part.Name,
                RecipeIngredients = part.RecipeIngredients
            };
        }
    }
}

