using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Psinder.Core.Model;
using Psinder.Core.Result;

namespace Psinder.Services.UserServices
{
    public interface IUserServices
    {
        Task<Result> CreateAsync(User newUser, string password);
        Task DeleteAsync(ClaimsPrincipal user, string passwordConfirm);
        Task UpdateAsync(User user);
        Task ChangePasswordAsync(ClaimsPrincipal user, string currentPassword, string newPassword);
        Task<User> GetAsync(string id);
        Task<User> GetAsync(ClaimsPrincipal user);
    }
}
