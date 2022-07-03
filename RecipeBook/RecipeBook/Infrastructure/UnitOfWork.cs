using RecipeBook.Application;

namespace RecipeBook.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly RecipeDbContext _dbContext;

        public UnitOfWork(RecipeDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Commit()
        {
            _dbContext.SaveChanges();
        }
    }
}
