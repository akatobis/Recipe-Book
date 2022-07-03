using Microsoft.EntityFrameworkCore;
using RecipeBook.Application.Models;
using RecipeBook.Application.RepositoriesInterfaces;
using System.Linq;

namespace RecipeBook.Infrastructure.Repositories
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
                .Include( x => x.RecipeSteps )
                .Include( x => x.RecipeIngredientsBlocks )
                .Include( x => x.RecipeTags )
                .FirstOrDefault( x => x.RecipeId == id );
        }

        public Recipe GetRecipeOfDay()
        {
            return _dbContext.Set<Recipe>()
                .FirstOrDefault( x => x.CreatingDate == DateTime.Today );
        }

        public Recipe[] GetRecipes( int skip, string search )
        {

            if ( search != null )
            {
                return _dbContext.Set<Recipe>()
                    .Skip( skip )
                    .Include( x => x.RecipeTags )
                    .Where( x => x.Title.Contains( search ) || x.RecipeTags.Any( s => s.Name.Contains( search ) ) )
                    .Take( 5 )
                    .ToArray();
            }

            return _dbContext.Set<Recipe>()
                .Skip( skip )
                .Include( x => x.RecipeTags )
                .Take( 5 )
                .ToArray();
        }
    }
}
