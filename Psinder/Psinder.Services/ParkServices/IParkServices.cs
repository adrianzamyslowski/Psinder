using Psinder.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psinder.Services.ParkServices
{
    public interface IParkServices
    {
        Task AddAsync(Park park);
        Task DeleteAsync(int id);
        Task<List<Park>> GetAllAsync();
        Task<Park> GetAsync(int id);
        Task UpdateAsync(int id, Park park);
    }
}
