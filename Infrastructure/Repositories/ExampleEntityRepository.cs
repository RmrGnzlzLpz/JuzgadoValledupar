﻿using Domain.Entities;
using Domain.Repositories;
using Infrastructure.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repositories
{
    public class ExampleEntityRepository : GenericRepository<ExampleEntity>, IExampleEntityRepository
    {
        public ExampleEntityRepository(IDbContext context) : base(context)
        {
        }
    }
}
