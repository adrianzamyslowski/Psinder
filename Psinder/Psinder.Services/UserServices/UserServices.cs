using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.Identity.Client;
using Psinder.Core.Interfaces;
using Psinder.Core.Model;
using Psinder.Core.Model.Enums;
using Psinder.Core.Result;

namespace Psinder.Services.UserServices
{
    public class UserServices : IUserServices
    {
        private readonly IUserRepository _userRepository;
        private readonly UserManager<User> _userManager;

        public UserServices(IUserRepository userRepository, UserManager<User> userManager)
        {
            _userRepository = userRepository;
            _userManager = userManager;
        }


        public async Task<Result> CreateAsync(User newUser, string password)
        {
            var result = new Result();

            result.IsSucceed = true;
            result.StatusCode = HttpStatusCode.OK;

            var identityResult = await _userManager.CreateAsync(newUser, password);
            if (!identityResult.Succeeded)
            {
                result.IsSucceed = false;
                result.Messages.Add(new ErrorMessage("", "Nie udało się utworzyć użytkownia"));
                result.StatusCode = HttpStatusCode.InternalServerError;
            }
            identityResult = await _userManager.AddToRoleAsync(newUser, UserRoles.RegularUser.ToString());

            if (identityResult.Succeeded)
            {
                result.IsSucceed = false;
                result.Messages.Add(new ErrorMessage("", "Nie udało się nadać roli"));
                result.StatusCode = HttpStatusCode.InternalServerError;
            }

            return result;
        }

        public async Task DeleteAsync(ClaimsPrincipal user, string passwordConfirm)
        {
            var userDelete = await GetAsync(user);

            if (!await _userManager.CheckPasswordAsync(userDelete, passwordConfirm))
            {
                throw new Exception(); 
            }

            await _userRepository.Delete(userDelete);
        }

        public async Task UpdateAsync(User user)
        {
            var userToUpade = await GetAsync(user.Id);
            userToUpade.Email = user.Email;
            userToUpade.DateOfBirth = user.DateOfBirth;
        }

        public async Task ChangePasswordAsync(ClaimsPrincipal user, string currentPassword, string newPassword)
        {
            var userToUpdate = await GetAsync(user);
            await _userManager.ChangePasswordAsync(userToUpdate, currentPassword, newPassword);
        }

        public async Task<User> GetAsync(string id)
        {
            return await _userRepository.Get(id);
        }

        public async Task<User> GetAsync(ClaimsPrincipal user)
        {
            return await _userRepository.Get(user.FindFirst(ClaimTypes.NameIdentifier).Value);
        }
    }
}
