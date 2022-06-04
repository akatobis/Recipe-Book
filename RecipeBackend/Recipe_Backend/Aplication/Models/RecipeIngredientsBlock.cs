namespace Recipe_Backend.Aplication.Models
{
    public class RecipeIngredientsBlock
    {
        public RecipeIngredientsBlock()
        {

        }
        public int RecipePartId { get; set; }
        public string Name { set; get; }
        public string RecipeIngredients { get; set; }
        public int RecipeId { get; set; }
        //public Recipe Recipe { get; set; }
    }
}