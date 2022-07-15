using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RecipeBook.Application.Models;

namespace RecipeBook.Infrastructure.Configuration
{
    public class RecipeRecipeIngredientsBlockConfiguration : IEntityTypeConfiguration<RecipeIngredientsBlock>
    {
        public void Configure( EntityTypeBuilder<RecipeIngredientsBlock> builder )
        {
            builder.ToTable( "recipe_part" )
                .HasKey( item => item.RecipePartId );

            builder.Property( item => item.RecipePartId )
                .UseIdentityColumn()
                .IsRequired();

            builder.Property( x => x.Name )
                .HasMaxLength(250)
                .IsRequired();

            builder.Property( x => x.RecipeIngredients )
                .HasMaxLength(500)
                .IsRequired();

            builder.Property( x => x.RecipeId )
                .IsRequired();
        }
    }
}
