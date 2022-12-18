using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Psinder.Core.Interfaces;
using Psinder.Core.Model;

namespace Psinder.Repository.Repository
{
    public class DogRepository :IDogRepository
    {
        private readonly PsinderContext _psinderContext;

        public DogRepository(PsinderContext psinderContext)
        {
            this._psinderContext = psinderContext;
        }
        public Task<List<Dog>> GetAll()
        {
            throw new NotImplementedException();

           }

        public Task Add(Dog dog)
        {
            throw new NotImplementedException();
        }

        public Task<Dog> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Dog dog)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Dog dog)
        {
            throw new NotImplementedException();
        }
    }
}
