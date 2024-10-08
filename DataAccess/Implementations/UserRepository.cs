﻿using DataAccess.Interfaces;
using DomainModels;

namespace DataAccess.Implementations
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        private readonly LiquorStoreDbContext _context;
        public UserRepository(LiquorStoreDbContext context) : base(context)
        {
            _context = context;
        }

        public User LoginUser(string username, string hashPassword)
        {
            return _context.Users.SingleOrDefault(x => x.Username == username &&
                                                       x.Password == hashPassword);
        }

        public User GetByUsername(string username)
        {
            return _context.Users.SingleOrDefault(x => x.Username == username);
        }
    }
}
