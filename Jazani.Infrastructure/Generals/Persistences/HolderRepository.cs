﻿using Jazani.Domain.Generals.Models;
using Jazani.Domain.Generals.Repositories;
using Jazani.Infrastructure.Cores.Contexts;
using Jazani.Infrastructure.Cores.Persistences;

namespace Jazani.Infrastructure.Generals.Persistences
{
    public class HolderRepository : CrudRepository<Holder, int>,IHolderRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public HolderRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }


    }
}
