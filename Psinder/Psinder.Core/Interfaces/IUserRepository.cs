using Psinder.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psinder.Core.Interfaces
{
    public interface IUserRepositor
    {

        Task<List<User>> GetAll();
        Task Add(User user);
        Task<User> Get(int id);
        Task Update(User user);
        Task Delete(User user);

    }
}
