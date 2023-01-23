using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Psinder.Core.Interfaces;
using Psinder.Core.Model;

namespace Psinder.Repository.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly PsinderContext _psinderContext;

        public UserRepository(PsinderContext psinderContext)
        {
            _psinderContext = psinderContext;
        }

        public async Task<List<User>> GetAll()
        {
            return await _psinderContext.Users
                .Include(u => u.Dogs)
                .Include(u => u.Meetings)
                .ToListAsync();
        }

        public async Task<List<User>> GetUserByName(string userName)
        {
            return await _psinderContext.Users
                .Where(u => u.UserName.ToLower().Contains(userName.ToLower()))
                .Include(u=>u.Dogs)
               
                .ToListAsync();
        }

        public async Task<User?> Get(string id)
        {
            return await _psinderContext.Users
                .Include(u=>u.Dogs)
                .Include(u=>u.Meetings)
                .SingleOrDefaultAsync(u => u.Id == id);
        }

        public async Task Add(User user)
        {
            await _psinderContext.Users.AddAsync(user);
            await _psinderContext.SaveChangesAsync();
        }

        public async Task Update(User user)
        {
            _psinderContext.Users.Update(user);
            await _psinderContext.SaveChangesAsync();
        }

        public async Task Delete(User user)
        {
            _psinderContext.Users.Remove(user);
            await _psinderContext.SaveChangesAsync();
        }
    }
}
