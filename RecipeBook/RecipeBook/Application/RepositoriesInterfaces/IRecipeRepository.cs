using RecipeBook.Application.Models;

namespace RecipeBook.Application.RepositoriesInterfaces
{
    public interface IRecipeRepository
    {
        Recipe GetRecipeById( int id );
        Recipe[] GetRecipes( int skip, string search );
        Recipe GetRecipeOfDay();
        void CreateRecipe( Recipe recipe );
        void DeleteRecipe( int id );
    }
}

