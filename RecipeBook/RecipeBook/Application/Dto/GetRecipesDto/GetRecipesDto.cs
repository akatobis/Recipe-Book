using RecipeBook.Application.Dto.GetRecipeDto;

namespace RecipeBook.Application.Dto.GetRecipesDto
{
    public class GetRecipesDto
    {
        public GetRecipesDto(
            int recipeId,
            string title,
            string description,
            int cookingTime,
            int portions,
            string image,
            ICollection<RecipeTagDto> recipeTags,
            int recipeFavouritesCount,
            int recipeLikesCount )
        {
            RecipeId = recipeId;
            Title = title;
            Description = description;
            CookingTime = cookingTime;
            Portions = portions;
            Image = image;
            RecipeLikesCount = recipeLikesCount;
            RecipeFavouritesCount = recipeFavouritesCount;
            RecipeTags = recipeTags;
        }
        public int RecipeId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int CookingTime { get; set; }
        public int Portions { get; set; }
        public string Image { get; set; }
        public int RecipeLikesCount { get; set; }
        public int RecipeFavouritesCount { get; set; }
        public ICollection<RecipeTagDto> RecipeTags { get; set; }
    }
}
