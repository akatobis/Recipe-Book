using Recipe_Backend.Aplication.Dto;
using Recipe_Backend.Aplication.Dto.CreateRecipeDto;
using Recipe_Backend.Aplication.Models;

namespace Recipe_Backend.Extensions
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
                Name = part.Name
            };
        }

        public static List<RecipeLikeDto> ToDto( this IEnumerable<RecipeLike> recipeLikes )
        {
            return recipeLikes.Select( s => s.ToDto() ).ToList();
        }

        public static RecipeLikeDto ToDto( this RecipeLike like )
        {
            return new RecipeLikeDto
            {
                Count = like.Count
            };
        }

        public static List<RecipeFavouriteDto> ToDto( this IEnumerable<RecipeFavourite> recipeFavourites )
        {
            return recipeFavourites.Select( s => s.ToDto() ).ToList();
        }

        public static RecipeFavouriteDto ToDto( this RecipeFavourite favourite )
        {
            return new RecipeFavouriteDto
            {
                Count = favourite.Count
            };
        }
    }
}
