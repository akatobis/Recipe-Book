namespace RecipeBook.Application.Models
{
    public class RecipeFavourite
    {
        public RecipeFavourite()
        {

        }
        public RecipeFavourite( int count )
        {
            Count = count;
        }
        public int RecipeFavouriteId { get; set; }
        public int Count { get; set; }
        public int RecipeId { get; set; }
    }
}
