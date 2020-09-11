using Domain.Contracts;
using Domain.Repositories;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Base
{
    public class UnitOfWork : IUnitOfWork
    {
        public IDbContext _dbContext;
        public UnitOfWork(IDbContext context)
        {
            _dbContext = context;
        }
        #region private repositories
        private IExampleEntityRepository _exampleEntityRepository;
        #endregion
        #region public repositories
        public IExampleEntityRepository ExampleEntityRepository
        {
            get { return _exampleEntityRepository ?? (_exampleEntityRepository = new ExampleEntityRepository(_dbContext)); }
        }
        #endregion

        public int Commit()
        {
            return _dbContext.SaveChanges();
        }
        public void Dispose()
        {
            Dispose(true);
        }
        private void Dispose(bool disposing)
        {
            if (disposing && _dbContext != null)
            {
                ((DbContext)_dbContext).Dispose();
                _dbContext = null;
            }
        }
    }
}
