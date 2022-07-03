using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RecipeBook.Application.Models;

namespace RecipeBook.Infrastructure.Configuration
{
    public class RecipeLikeConfiguration : IEntityTypeConfiguration<RecipeLike>
    {
        public void Configure( EntityTypeBuilder<RecipeLike> builder )
        {
            builder.ToTable( "recipe_like" )
                .HasKey( item => item.RecipeLikeId );

            builder.Property( item => item.RecipeLikeId )
                .UseIdentityColumn()
                .IsRequired();

            builder.Property( x => x.Count )
                .IsRequired();

            builder.Property( x => x.RecipeId )
                .IsRequired();
        }
    }
}
