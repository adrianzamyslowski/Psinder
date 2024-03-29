﻿using Psinder.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psinder.Core.Interfaces
{
    public interface IUserRepository
    {
        Task<List<User>> GetAll();
        Task<List<User>> GetUserByName(string userName);
        Task<User> Get(string Id);
        Task Add(User user);
        Task Update(User user);
        Task Delete(User user);
    }
}
