using Recipe_Backend.Aplication;

namespace Recipe_Backend.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly RecipeDbContext _dbContext;

        public UnitOfWork( RecipeDbContext dbContext )
        {
            _dbContext = dbContext;
        }

        public void Commit()
        {
            _dbContext.SaveChanges();
        }
    }
}
