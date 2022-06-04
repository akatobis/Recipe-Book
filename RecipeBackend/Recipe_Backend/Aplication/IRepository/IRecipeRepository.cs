using Recipe_Backend.Aplication.Models;

namespace Recipe_Backend.Aplication.Repository
{
    public interface IRecipeRepository
    {
        Recipe GetRecipeById( int id );
        void CreateRecipe( Recipe recipe );
        void DeleteRecipe( int id );
    }
}
