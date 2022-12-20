using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Psinder.Core.Model;

namespace Psinder.Services.PlayerServices
{
    public interface IPlayerServices
    {
        Task Create(User newUser, string password);
        Task Delete(ClaimsPrincipal user);
        Task Update(User user);
        Task ChangePassword(ClaimsPrincipal user, string currentPassword, string newPassword);
        Task<User> Get(string name);
        Task<User> Get(ClaimsPrincipal user);
    }
}
