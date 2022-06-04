namespace Recipe_Backend.Aplication.Models
{
    public class RecipeStep
    {
        public RecipeStep()
        {

        }
        public int RecipeStepId { get; set; } 
        public int SortNumber { get; set; }
        public string Description { get; set; }
        public int RecipeId { get; set; }
        //public Recipe Recipe { get; set; }
    }
}
