using Microsoft.EntityFrameworkCore;
using Psinder.Core.Interfaces;
using Psinder.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psinder.Repository.Repository
{
    public class MeetingRepository : IMeetingRepository
    {
        private readonly PsinderContext _psinderContext;

        public MeetingRepository(PsinderContext psinderContext)
        {
            _psinderContext = psinderContext;
        }

        public async Task Add(Meeting meeting)
        {
            _psinderContext.Add(meeting);
            await _psinderContext.SaveChangesAsync();
        }

        public async Task Delete(Meeting meeting)
        {
            _psinderContext.Remove(meeting);
            await _psinderContext.SaveChangesAsync();
        }

        public async Task<List<Meeting>> GetAll()
        {
            return await _psinderContext.Meetings
                .Include(m => m.User)
                .Include(m => m.DogOnMeetings)
                .ToListAsync();
        }

        public async Task<Meeting?> GetById(int id)
        {
            return await _psinderContext.Meetings
                .Include(m => m.User)
                .Include(m => m.DogOnMeetings)
                .SingleOrDefaultAsync(m => m.Id == id);
        }

        public async Task Update(Meeting meeting)
        {
            _psinderContext.Update(meeting);
            await _psinderContext.SaveChangesAsync();
        }
    }
}
