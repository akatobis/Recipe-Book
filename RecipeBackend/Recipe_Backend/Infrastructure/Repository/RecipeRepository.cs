using Microsoft.EntityFrameworkCore;
using Recipe_Backend.Aplication.Models;
using Recipe_Backend.Aplication.Repository;

namespace Recipe_Backend.Infrastructure.Repository
{
    public class RecipeRepository : IRecipeRepository
    {
        private readonly RecipeDbContext _dbContext;

        public RecipeRepository( RecipeDbContext dbContext )
        {
            _dbContext = dbContext;
        }

        public void CreateRecipe( Recipe recipe )
        {
            _dbContext.Set<Recipe>().Add( recipe );
        }

        public void DeleteRecipe( int id )
        {
            Recipe recipe = GetRecipeById( id );

            _dbContext.Set<Recipe>().Remove( recipe );
        }

        public Recipe GetRecipeById( int id )
        {
            return _dbContext.Set<Recipe>()
                .Include( x => x.RecipeTags )
                .Include( x => x.RecipeSteps )
                .Include( x => x.RecipeIngredientsBlocks )
                .Include( x => x.RecipeFavourites )
                .Include( x => x.RecipeLikes )
                .FirstOrDefault( x => x.RecipeId == id );
        }
    }
}
