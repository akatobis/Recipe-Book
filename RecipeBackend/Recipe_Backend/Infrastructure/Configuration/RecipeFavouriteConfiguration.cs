﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Recipe_Backend.Aplication.Models;

namespace Recipe_Backend.Infrastructure.Configuration
{
    public class RecipeFavouriteConfiguration : IEntityTypeConfiguration<RecipeFavourite>
    {
        public void Configure( EntityTypeBuilder<RecipeFavourite> builder )
        {
            builder.ToTable( "recipe_favourite" )
                .HasKey( item => item.RecipeFavouriteId );

            builder.Property( item => item.RecipeFavouriteId )
                .UseIdentityColumn()
                .IsRequired();

            builder.Property( x => x.Count )
                .IsRequired();

            builder.Property( x => x.RecipeId )
                .IsRequired();
        }
    }
}
