using Microsoft.AspNetCore.Identity;
using Psinder.Core.Interfaces;
using Psinder.Core.Model;
using Psinder.Services.UserServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Psinder.Services.DogServices
{
    public class DogServices : IDogServices
    {
        private readonly IUserServices _userServices;
        private readonly IDogRepository _dogRepository;

        public DogServices(IUserServices userServices, IDogRepository dogRepository)
        {
            _userServices = userServices;
            _dogRepository = dogRepository;
        }

        public async Task Add(ClaimsPrincipal user, Dog dog)
        {
            var userToAddDog = await _userServices.Get(user);
            await _dogRepository.Add(userToAddDog, dog);
        }

        public async Task Delete(int id)
        {
            await _dogRepository.Delete(await Get(id));
        }

        public async Task<Dog> Get(int id)
        {
            return await _dogRepository.GetById(id);
        }

        public async Task<List<Dog>> Get(string name)
        {
            return await _dogRepository.GetDogByNme(name);
        }

        public async Task<List<Dog>> GetAllUserDogs(ClaimsPrincipal user)
        {
            var userToListDog = await _userServices.Get(user);
            return userToListDog.Dogs;
        }

        public async Task Update(int id, Dog dog)
        {
            var dogToUpdate = await Get(id);
            dogToUpdate.Name = dog.Name;
            dogToUpdate.DateOfBirth = dog.DateOfBirth;
            //zmiana na wyciągniętą rasę z bazy(uniąć błędów z referencjami)
            dogToUpdate.DogBreeds = dog.DogBreeds;
            dogToUpdate.Gender = dog.Gender;
            
            await _dogRepository.Update(dogToUpdate);
        }
    }
}
