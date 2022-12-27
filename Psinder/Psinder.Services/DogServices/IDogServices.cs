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
        Task Add(ClaimsPrincipal user, Dog dog);
        Task Delete(int id);
        Task Update(int id, Dog dog);
        Task<Dog> Get(int id);
        Task<List<Dog>> Get(string name);
        Task<List<Dog>> GetAllUserDogs(ClaimsPrincipal user);
    }
}
