using Psinder.Core.Model;
using Psinder.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psinder.Services.ParkServices
{ 
    public class ParkServices : IParkServices
    {
        private readonly ParkRepository _parkRepository;

        public ParkServices(ParkRepository parkRepository)
        {
            _parkRepository = parkRepository;
        }

        public async Task AddAsync(Park park)
        {
           await _parkRepository.Add(park);
        }

        public async Task DeleteAsync(int id)
        {
            await _parkRepository.Delete(await GetAsync(id));
        }

        public async Task<List<Park>> GetAllAsync()
        {
            return await _parkRepository.GetAll();
        }

        public async Task<Park> GetAsync(int id)
        {
           return await _parkRepository.GetById(id);
        }

        public async Task UpdateAsync(int id, Park park)
        {
            var parkToUpdate = await GetAsync(id);
            parkToUpdate.NamePark = park.NamePark;
            parkToUpdate.Street = park.Street;
            parkToUpdate.City = park.City;
            parkToUpdate.Country = park.Country;

            await _parkRepository.Update(parkToUpdate);
        }              
    }
}
