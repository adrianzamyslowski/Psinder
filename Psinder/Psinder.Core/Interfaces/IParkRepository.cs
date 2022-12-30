using Psinder.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psinder.Core.Interfaces
{
    public interface IParkRepository
    {
        Task<List<Park>> GetAll();
        Task<Park> GetById(int id);
        Task<List<Park>> GetParkByName(string parkName);
        Task Add(Park park);
        Task Update(Park park);
        Task Delete(Park park);
    }
}
