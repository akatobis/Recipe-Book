namespace RecipeBook.Application.Models
{
    public class RecipeIngredientsBlock
    {
        public RecipeIngredientsBlock()
        {

        }
        public RecipeIngredientsBlock( string name, string recipeIngredients )
        {
            Name = name;
            RecipeIngredients = recipeIngredients;
        }
        public int RecipePartId { get; set; }
        public string Name { set; get; }
        public string RecipeIngredients { get; set; }
        public int RecipeId { get; set; }
    }
}
