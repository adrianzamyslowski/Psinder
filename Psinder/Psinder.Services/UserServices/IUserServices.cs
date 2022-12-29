﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Psinder.Core.Model;

namespace Psinder.Services.UserServices
{
    public interface IUserServices
    {
        Task CreateAsync(User newUser, string password);
        Task DeleteAsync(ClaimsPrincipal user);
        Task UpdateAsync(User user);
        Task ChangePasswordAsync(ClaimsPrincipal user, string currentPassword, string newPassword);
        Task<User> GetAsync(string id);
        Task<User> GetAsync(ClaimsPrincipal user);
    }
}
