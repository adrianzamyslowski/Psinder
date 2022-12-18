using Psinder.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psinder.Core.Interfaces
{
    public interface IDogRepository
    {
        Task<List<Dog>> GetAll();
        Task Add(Dog dog);
        Task<Dog> Get(int id);
        Task Update(Dog dog);
        Task Delete(Dog dog);
    }
}
