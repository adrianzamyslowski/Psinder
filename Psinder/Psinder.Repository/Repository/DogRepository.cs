using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Psinder.Core.Interfaces;
using Psinder.Core.Model;

namespace Psinder.Repository.Repository
{
    public class DogRepository: IDogRepository
    {
        private readonly PsinderContext _psinderContext;

        public DogRepository(PsinderContext psinderContext)
        {
            _psinderContext = psinderContext;
        }


        public async Task<List<Dog>> GetAll()
        {
            return await _psinderContext.Dogs
                .ToListAsync();
        }

        public async Task<List<Dog>> GetDogByNme(string dogName)
        {
            return await _psinderContext.Dogs
                .Where(d => d.Name.ToLower().Contains(dogName.ToLower()))
                .ToListAsync();
        }

        public async Task Add(User user, Dog dog)
        {
            user.Dogs.Add(dog);
            await _psinderContext.SaveChangesAsync();
        }

        public async Task Update(Dog dog)
        {
            _psinderContext.Dogs.Update(dog);
            await _psinderContext.SaveChangesAsync();
        }

        public async Task Delete(Dog dog)
        {
            _psinderContext.Dogs.Remove(dog);
            await _psinderContext.SaveChangesAsync();
        }
    }
    
}
