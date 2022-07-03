using Microsoft.EntityFrameworkCore;
using RecipeBook.Infrastructure.Configuration;

namespace RecipeBook.Infrastructure
{
    public class RecipeDbContext : DbContext
    {
        public RecipeDbContext( DbContextOptions<RecipeDbContext> options )
            : base( options )
        {
        }

        protected override void OnModelCreating( ModelBuilder modelBuilder )
        {
            modelBuilder.ApplyConfiguration( new RecipeConfiguration() );
            modelBuilder.ApplyConfiguration( new RecipeTagConfiguration() );
            modelBuilder.ApplyConfiguration( new RecipeStepConfiguration() );
            modelBuilder.ApplyConfiguration( new RecipeRecipeIngredientsBlockConfiguration() );
        }
    }
}
