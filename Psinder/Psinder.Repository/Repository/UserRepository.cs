using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Identity.Client;
using Psinder.Core.Interfaces;
using Psinder.Core.Model;

namespace Psinder.Repository.Repository
{
    public class UserRepository: IUserRepositor
    {
        private readonly PsinderContext _psinderContext;

        public UserRepository(PsinderContext psinderContext)
        {
            _psinderContext = psinderContext;
        }

        public Task<List<User>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task Add(User user)
        {
            throw new NotImplementedException();
        }

        public Task<User> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(User user)
        {
            throw new NotImplementedException();
        }

        public Task Delete(User user)
        {
            throw new NotImplementedException();
        }
    }
}
