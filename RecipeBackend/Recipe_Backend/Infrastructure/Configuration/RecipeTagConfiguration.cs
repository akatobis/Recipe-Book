using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Recipe_Backend.Aplication.Models;

namespace Recipe_Backend.Infrastructure.Configuration
{
    public class RecipeTagConfiguration : IEntityTypeConfiguration<RecipeTag>
    {
        public void Configure( EntityTypeBuilder<RecipeTag> builder )
        {
            builder.ToTable( "recipe_tag" )
                .HasKey( item => item.RecipeTagId );

            builder.Property( item => item.RecipeTagId )
                .UseIdentityColumn()
                .IsRequired();

            builder.Property( x => x.Name )
                .HasMaxLength( 60 )
                .IsRequired();

            builder.Property( x => x.RecipeId )
                .IsRequired();
        }
    }
}
