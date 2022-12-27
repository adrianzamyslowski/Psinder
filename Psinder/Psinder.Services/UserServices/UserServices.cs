using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.Identity.Client;
using Psinder.Core.Interfaces;
using Psinder.Core.Model;
using Psinder.Core.Model.Enums;

namespace Psinder.Services.UserServices
{
    public class UserServices : IUserServices
    {
        private readonly IUserRepositor _userRepositor;
        private readonly UserManager<User> _userManager;

        public UserServices(IUserRepositor userRepositor, UserManager<User> userManager)
        {
            _userRepositor = userRepositor;
            _userManager = userManager;
        }


        public async Task Create(User newUser, string password)
        {
            var result = await _userManager.CreateAsync(newUser, password);
            result = await _userManager.AddToRoleAsync(newUser, UserRoles.RegularUser.ToString());
        }

        public async Task Delete(ClaimsPrincipal user)
        {
            var result = await Get(user);

            await _userRepositor.Delete(result);
        }

        public async Task Update(User user)
        {
            var userToUpade = await Get(user.Id);
            userToUpade.Email = user.Email;
            userToUpade.DateOfBirth = user.DateOfBirth;
        }

        public async Task ChangePassword(ClaimsPrincipal user, string currentPassword, string newPassword)
        {
            var userToUpdate = await Get(user);
            await _userManager.ChangePasswordAsync(userToUpdate, currentPassword, newPassword);
        }

        public async Task<User> Get(string id)
        {
            return await _userRepositor.Get(id);
        }

        public async Task<User> Get(ClaimsPrincipal user)
        {
            return await _userRepositor.Get(user.FindFirst(ClaimTypes.NameIdentifier).Value);
        }
    }
}
