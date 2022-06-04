using Recipe_Backend.Aplication.Models;

namespace Recipe_Backend.Aplication.Dto
{
    public class RecipeDto
    {
        public RecipeDto(
            string title,
            string description,
            int cookingTime,
            int portions,
            string image,
            ICollection<RecipeIngredientsBlockDto> recipeParts,
            ICollection<RecipeStepDto> recipeSteps,
            ICollection<RecipeLikeDto> recipeLikes,
            ICollection<RecipeFavouriteDto> recipeFavourites,
            ICollection<RecipeTagDto> recipeTags )
        {
            Title = title;
            Description = description;
            CookingTime = cookingTime;
            Portions = portions;
            Image = image;
            RecipeParts = recipeParts;
            RecipeSteps = recipeSteps;
            RecipeLikes = recipeLikes;
            RecipeFavourites = recipeFavourites;
            RecipeTags = recipeTags;
        }
        public string Title { get; set; }
        public string Description { get; set; }
        public int CookingTime { get; set; }
        public int Portions { get; set; }
        public string Image { get; set; }
        public ICollection<RecipeFavouriteDto> RecipeFavourites { get; set; }
        public ICollection<RecipeLikeDto> RecipeLikes { get; set; }
        public ICollection<RecipeIngredientsBlockDto> RecipeParts { get; set; }
        public ICollection<RecipeStepDto> RecipeSteps { get; set; }
        public ICollection<RecipeTagDto> RecipeTags { get; set; }
    }
}
