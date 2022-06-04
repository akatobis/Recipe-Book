namespace Recipe_Backend.Aplication.Models
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
            ICollection<RecipeLike> recipeLikes,
            ICollection<RecipeFavourite> recipeFavourites,
            ICollection<RecipeTag> recipeTags )
        {
            Title = title;
            Description = description;
            CookingTime = cookingTime;
            Portions = portions;
            Image = image;
            CreatingDate = DateTime.Today;
            RecipeIngredientsBlocks = recipeIngredientsBlocks;
            RecipeSteps = recipeSteps;
            RecipeLikes = recipeLikes;
            RecipeFavourites = recipeFavourites;
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
        public ICollection<RecipeLike> RecipeLikes { get; set; }
        public ICollection<RecipeFavourite> RecipeFavourites { get; set; }
        public ICollection<RecipeTag> RecipeTags { get; set; }
    }
}
