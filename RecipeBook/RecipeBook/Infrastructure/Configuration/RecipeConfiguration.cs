using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RecipeBook.Application.Models;

namespace RecipeBook.Infrastructure.Configuration
{
    public class RecipeConfiguration : IEntityTypeConfiguration<Recipe>
    {
        public void Configure( EntityTypeBuilder<Recipe> builder )
        {
            builder.ToTable( "recipe" )
                .HasKey( item => item.RecipeId );

            builder.Property( item => item.RecipeId )
                .UseIdentityColumn()
                .IsRequired();

            builder.Property( x => x.Title )
                .HasMaxLength( 250 )
                .IsRequired();

            builder.Property( x => x.Description )
                .HasMaxLength( 1000 )
                .IsRequired();

            builder.Property( x => x.CookingTime )
                .IsRequired();

            builder.Property( x => x.Portions )
                .IsRequired();

            builder.Property( x => x.Image )
                .HasMaxLength( 250 );

            builder.Property( x => x.CreatingDate )
                .IsRequired();

            builder.Property( x => x.RecipeLikesCount )
                .IsRequired();

            builder.Property( x => x.RecipeFavouritesCount )
                .IsRequired();

            builder.HasMany( x => x.RecipeIngredientsBlocks )
                .WithOne()
                .HasForeignKey( FK => FK.RecipeId )
                .IsRequired();

            builder.HasMany( x => x.RecipeSteps )
                .WithOne()
                .HasForeignKey( FK => FK.RecipeId )
                .IsRequired();

            builder.HasMany( x => x.RecipeTags )
                .WithOne()
                .HasForeignKey( FK => FK.RecipeId )
                .IsRequired();
        }
    }
}
