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

namespace Psinder.Services.PlayerServices
{
    public class PlayerServices : IPlayerServices
    {
        private readonly IUserRepositor _userRepositor;
        private readonly UserManager<User> _userManager;

        public PlayerServices(IUserRepositor userRepositor, UserManager<User> userManager)
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

        public Task ChangePassword(ClaimsPrincipal user, string currentPassword, string newPassword)
        {
            throw new NotImplementedException();
        }

        public Task<User> Get(string id)
        {
            var result = _userRepositor.Get(id);
            return result;
        }

        public Task<User> Get(ClaimsPrincipal user)
        {
            throw new NotImplementedException();
        }
    }
}
