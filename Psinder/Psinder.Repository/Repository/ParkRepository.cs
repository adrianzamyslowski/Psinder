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
    public class ParkRepository:IParkRepository
    {
        private readonly PsinderContext _psinderContext;

        public ParkRepository(PsinderContext psinderContext)
        {
            _psinderContext = psinderContext;
        }

        public async Task<List<Park>> GetAll()
        {
            return await _psinderContext.Parks
                .Include(p=>p.Mettings)
                .ToListAsync();
        }

        public async Task<Park> GetById(int id)
        {
           return await _psinderContext.Parks.SingleOrDefaultAsync(p => p.Id == id);
        }          

        public async Task<List<Park>> GetParkByName(string parkName)
        {
            return await _psinderContext.Parks
                .Where(p => p.NamePark.ToLower().Contains(parkName))
                .Include(p=>p.Mettings)
                .ToListAsync();
        }

        public async Task Add(Park park)
        {
            await _psinderContext.Parks.AddAsync(park);
            await _psinderContext.SaveChangesAsync();
        }

        public async Task Update(Park park)
        {
            _psinderContext.Parks.Update(park);
            await _psinderContext.SaveChangesAsync();
        }

        public async Task Delete(Park park)
        {
            _psinderContext.Parks.Remove(park);
            await _psinderContext.SaveChangesAsync();
        }
    }
}
