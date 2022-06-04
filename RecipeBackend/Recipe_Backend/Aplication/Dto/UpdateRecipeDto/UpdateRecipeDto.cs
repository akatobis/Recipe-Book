using Recipe_Backend.Aplication.Dto.CreateRecipeDto;

namespace Recipe_Backend.Aplication.Dto.UpdateRecipeDto
{
    public class UpdateRecipeDto
    {
        public int RecipeId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int CookingTime { get; set; }
        public int Portions { get; set; }
        public string Image { get; set; }
        public ICollection<UpdateRecipeFavouriteDto> RecipeFavourites { get; set; }
        public ICollection<UpdateRecipeLikeDto> RecipeLikes { get; set; }
        public ICollection<UpdateRecipeIngredientsBlockDto> RecipeIngredientsBlocks { get; set; }
        public ICollection<UpdateRecipeStepDto> RecipeSteps { get; set; }
        public ICollection<UpdateRecipeTagDto> RecipeTags { get; set; }
    }
}
