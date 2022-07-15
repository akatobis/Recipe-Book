using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RecipeBook.Application.Models;

namespace RecipeBook.Infrastructure.Configuration
{
    public class RecipeStepConfiguration : IEntityTypeConfiguration<RecipeStep>
    {
        public void Configure( EntityTypeBuilder<RecipeStep> builder )
        {
            builder.ToTable( "recipe_step" )
                .HasKey( item => item.RecipeStepId );

            builder.Property( item => item.RecipeStepId )
                .UseIdentityColumn()
                .IsRequired();

            builder.Property( x => x.Number )
                .IsRequired();

            builder.Property( x => x.Description )
                .HasMaxLength( 1000 )
                .IsRequired();

            builder.Property( x => x.RecipeId )
                .IsRequired();
        }
    }
}
