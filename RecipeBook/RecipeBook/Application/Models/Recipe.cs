namespace RecipeBook.Application.Models
{
    public class Recipe
    {
        public Recipe()
        {
        }
        public Recipe(
            string title,
            string description,
            int cookingTime,
            int portions,
            string image,
            ICollection<RecipeIngredientsBlock> recipeIngredientsBlocks,
            ICollection<RecipeStep> recipeSteps,
            ICollection<RecipeTag> recipeTags,
            int recipeLikesCount,
            int recipeFavouritesCount)
        {
            Title = title;
            Description = description;
            CookingTime = cookingTime;
            Portions = portions;
            Image = image;
            CreatingDate = DateTime.Today;
            RecipeIngredientsBlocks = recipeIngredientsBlocks;
            RecipeSteps = recipeSteps;
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
        public DateTime CreatingDate { get; set; }
        public ICollection<RecipeIngredientsBlock> RecipeIngredientsBlocks { get; set; }
        public ICollection<RecipeStep> RecipeSteps { get; set; }
        public ICollection<RecipeTag> RecipeTags { get; set; }
        public int RecipeLikesCount { get; set; }
        public int RecipeFavouritesCount { get; set; }
    }
}
