namespace Recipe_Backend.Aplication.Models
{
    public class RecipeFavourite
    {
        public RecipeFavourite()
        {

        }
        public int RecipeFavouriteId { get; set; }
        public int Count { get; set; }
        public int RecipeId { get; set; }
        //public Recipe Recipe { get; set; }
    }
}
