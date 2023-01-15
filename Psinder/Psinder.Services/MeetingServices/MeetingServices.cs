using Psinder.Core.Interfaces;
using Psinder.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psinder.Services.MeetingServices
{
    public class MeetingServices : IMeetingServices
    {
        private readonly IParkRepository _parkRepository;
        private readonly IMeetingRepository _meetingRepository;
        private readonly IDogRepository _dogRepository;
        private readonly IUserRepositor _userRepositor;

        public MeetingServices(IParkRepository parkRepository, IMeetingRepository meetingRepository, IDogRepository dogRepository, IUserRepositor userRepositor)
        {
            _parkRepository = parkRepository;
            _meetingRepository = meetingRepository;
            _dogRepository = dogRepository;
            _userRepositor = userRepositor;
        }

        public async Task AddAsync(Meeting meeting)
        {
            var parkId = meeting.ParkId;
            var userId = meeting.UserId;

            if (await _parkRepository.GetById(parkId) == null)
            {
                //dodać - bład brak parku
                throw new InvalidOperationException();
            }

            if (await _userRepositor.Get(userId) == null)
            {
                //dodać - bład brak użytownika
                throw new InvalidOperationException();
            }
            //data zakończenia (większa) niż data rozpoczecia - dodać sprawdzenie
            await _meetingRepository.Add(meeting);
        }

        public async Task DeleteAsync(int id)
        {
            var meeting = await GetAsync(id);
            await _meetingRepository.Delete(meeting);
        }

        public async Task<List<Meeting>> GetAllAsync()
        {
            return await _meetingRepository.GetAll();
        }

        public async Task<Meeting> GetAsync(int id)
        {
            return await _meetingRepository.GetById(id);
        }

        public async Task UpdateAsync(Meeting meeting)
        {
            //DODAĆ
            //park z repo po ID z wnętrza meetingu,sprawdzamy czy istnieje 
            //zwalidowac relacje dogOnMeeting czy istnieja , jak nie istienja to je dodać i sprawdzić czy wsszystkie dogi  wewnąrrz
            //dogOnMeeting też istnieją i są własnącią tego usera / 

            var meetingToUpdate = await GetAsync(meeting.Id);

            meetingToUpdate.StartDate = meeting.StartDate;
            meetingToUpdate.EndDate = meeting.EndDate;
            meetingToUpdate.Park = meeting.Park;

            meetingToUpdate.ParkId = meeting.ParkId;

            await _meetingRepository.Update(meetingToUpdate);
        }

        public async Task AddDogToMeetingAsync(Meeting meeting, int dogId)
        {
            //sprawdzenie czy pies należy do usera spotkania
            //dodać nowy obiekt dogOnMeeting do meetingu (utworzyć i dodać)
            //update meetingu (przez repository)
        }

        public async Task RemoveDogFromMeetingAsync(Meeting meeting, int dogId)
        {
            //czy taki jest na tym spotkanu
            //jeśli jest usunąc obiekt dogOnMeeitng z tego spotkania (z bazy danych)

        }
    }
}
