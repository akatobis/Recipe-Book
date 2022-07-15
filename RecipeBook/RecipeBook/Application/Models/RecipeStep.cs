namespace RecipeBook.Application.Models
{
    public class RecipeStep
    {
        public RecipeStep()
        {

        }
        public RecipeStep( int number, string description)
        {
            Number = number;
            Description = description;
        }
        public int RecipeStepId { get; set; }
        public int Number { get; set; }
        public string Description { get; set; }
        public int RecipeId { get; set; }
    }
}
