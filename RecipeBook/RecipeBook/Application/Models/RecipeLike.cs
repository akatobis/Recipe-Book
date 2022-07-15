namespace RecipeBook.Application.Models
{
    public class RecipeLike
    {
        public RecipeLike()
        {

        }
        public RecipeLike( int count )
        {
            Count = count;
        }
        public int RecipeLikeId { get; set; }
        public int Count { get; set; }
        public int RecipeId { get; set; }
    }
}
