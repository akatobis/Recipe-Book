using Recipe_Backend.Aplication.Models;

namespace Recipe_Backend.Aplication.Dto.CreateRecipeDto
{
    public class CreateRecipeDto
    {
        public int RecipeId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int CookingTime { get; set; }
        public int Portions { get; set; }
        public string Image { get; set; }
        public ICollection<RecipeFavourite> RecipeFavourites { get; set; }
        public ICollection<RecipeLike> RecipeLikes { get; set; }
        public ICollection<RecipeIngredientsBlock> RecipeIngredientsBlocks { get; set; }
        public ICollection<RecipeStep> RecipeSteps { get; set; }
        public ICollection<RecipeTag> RecipeTags { get; set; }
    }
}
