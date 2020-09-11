using Domain.Repositories;
using System;

namespace Domain.Contracts
{
    public interface IUnitOfWork : IDisposable
    {
        #region repositories
        IExampleEntityRepository ExampleEntityRepository { get; }
        #endregion
        int Commit();
    }
}
