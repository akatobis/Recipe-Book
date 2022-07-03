using RecipeBook.Application.Models;

namespace RecipeBook.Application.Dto.UpdateRecipeDto
{
    public class UpdateRecipeDto
    {
        public int RecipeId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int CookingTime { get; set; }
        public int Portions { get; set; }
        public string Image { get; set; }
        public ICollection<RecipeIngredientsBlock> RecipeIngredientsBlocks { get; set; }
        public ICollection<RecipeStep> RecipeSteps { get; set; }
        public ICollection<RecipeTag> RecipeTags { get; set; }
        public int RecipeLikesCount { get; set; }
        public int RecipeFavouritesCount { get; set; }    }
}
