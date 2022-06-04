namespace Recipe_Backend.Aplication.Models
{
    public class RecipeLike
    {
        public RecipeLike()
        {

        }
        public int RecipeLikeId { get; set; }
        public int Count { get; set; }
        public int RecipeId { get; set; }
        //public Recipe Recipe { get; set; }
    }
}
