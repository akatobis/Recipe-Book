using RecipeBook.Application.Models;

namespace RecipeBook.Application.Dto.GetRecipeDto
{
    public class GetRecipeDto
    {
        public GetRecipeDto(
            string title,
            string description,
            int cookingTime,
            int portions,
            string image,
            ICollection<RecipeIngredientsBlockDto> recipeIngredientsBlocks,
            ICollection<RecipeStepDto> recipeSteps,
            ICollection<RecipeTagDto> recipeTags,
            int recipeLikesCount,
            int recipeFavouritesCount )
        {
            Title = title;
            Description = description;
            CookingTime = cookingTime;
            Portions = portions;
            Image = image;
            RecipeIngredientsBlocks = recipeIngredientsBlocks;
            RecipeSteps = recipeSteps;
            RecipeLikesCount = recipeLikesCount;
            RecipeFavouritesCount = recipeFavouritesCount;
            RecipeTags = recipeTags;
        }
        public string Title { get; set; }
        public string Description { get; set; }
        public int CookingTime { get; set; }
        public int Portions { get; set; }
        public string Image { get; set; }
        public ICollection<RecipeIngredientsBlockDto> RecipeIngredientsBlocks { get; set; }
        public ICollection<RecipeStepDto> RecipeSteps { get; set; }
        public ICollection<RecipeTagDto> RecipeTags { get; set; }
        public int RecipeLikesCount { get; set; }
        public int RecipeFavouritesCount { get; set; }
    }
}
