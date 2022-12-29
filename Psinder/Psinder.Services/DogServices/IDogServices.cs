using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Psinder.Core.Model;

namespace Psinder.Services.DogServices
{
    public interface IDogServices
    {
        Task AddAsync(ClaimsPrincipal user, Dog dog);
        Task DeleteAsync(int id);
        Task UpdateAsync(int id, Dog dog);
        Task<Dog> GetAsync(int id);
        Task<List<Dog>> GetAsync(string name);
        Task<List<Dog>> GetAllUserDogsAsync(ClaimsPrincipal user);
    }
}
