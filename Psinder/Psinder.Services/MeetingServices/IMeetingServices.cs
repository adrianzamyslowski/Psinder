using Psinder.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psinder.Services.MeetingServices
{
    public interface IMeetingServices
    {
        Task AddAsync(Meeting meeting);
        Task<Meeting> GetAsync(int id);
        Task<List<Meeting>> GetAllAsync();
        Task DeleteAsync(int id);
        Task UpdateAsync(Meeting meeting);
    }
}
