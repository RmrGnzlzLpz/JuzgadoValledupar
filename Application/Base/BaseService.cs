using Domain.Base;
using Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Application.Base
{
    public abstract class Service<T> : BaseService, IService<T> where T : BaseEntity
    {
        public readonly IUnitOfWork _unitOfWork;
        public readonly IGenericRepository<T> _repository;
        public Service(IUnitOfWork unitOfWork, IGenericRepository<T> repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }
    }

    public abstract class BaseService
    {

    }
}