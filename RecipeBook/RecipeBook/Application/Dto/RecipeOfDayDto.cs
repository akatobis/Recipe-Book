namespace RecipeBook.Application.Dto
{
    public class RecipeOfDayDto
    {
        public RecipeOfDayDto(
            int recipeId,
            string title,
            string description,
            string image,
            int cookingTime,
            int recipeLikesCount )
        {
            RecipeId = recipeId;
            Title = title;
            Description = description;
            Image = image;
            CookingTime = cookingTime;
            RecipeLikesCount = recipeLikesCount;
        }
        public int RecipeId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int RecipeLikesCount { get; set; }
        public int CookingTime { get; set; }
    }
}
