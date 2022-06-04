﻿using Microsoft.EntityFrameworkCore;
using Recipe_Backend.Infrastructure.Configuration;

namespace Recipe_Backend.Infrastructure
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
            modelBuilder.ApplyConfiguration( new RecipeLikeConfiguration() );
            modelBuilder.ApplyConfiguration( new RecipeFavouriteConfiguration() );
        }
    }
}
