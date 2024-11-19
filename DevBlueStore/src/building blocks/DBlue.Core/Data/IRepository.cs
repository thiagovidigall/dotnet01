using System;
using DBlue.Core.DomainObjects;

namespace DBlue.Core.Data
{
    public interface IRepository<T> : IDisposable where T : IAggregateRoot
    {
        IUnitOfWork UnitOfWork { get; }
    }
}