﻿using DomainModels;

namespace DataAccess.Interfaces
{
    public interface IBeverageRepository : IRepository<Beverage>
    {
        public List<Beverage> GetByType(int type);
    }
}
