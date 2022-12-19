using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Psinder.Core.Interfaces;
using Psinder.Core.Model;

namespace Psinder.Repository.Repository
{
    public class ParkRepository:IParkRepository
    {
        private readonly PsinderContext _psinderContext;

        public ParkRepository(PsinderContext psinderContext)
        {
            _psinderContext = psinderContext;
        }


        public Task<List<Park>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task Add(Park park)
        {
            throw new NotImplementedException();
        }

        public Task<Park> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Park park)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Park park)
        {
            throw new NotImplementedException();
        }
    }
}
