namespace RecipeBook.Application.Models
{
    public class RecipeTag
    {
        public RecipeTag()
        {

        }
        public RecipeTag( string name )
        {
            Name = name;
        }
        public int RecipeTagId { get; set; }
        public string Name { get; set; }
        public int RecipeId { get; set; }

    }
}
