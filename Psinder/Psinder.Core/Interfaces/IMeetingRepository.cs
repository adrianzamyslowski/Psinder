using Psinder.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psinder.Core.Interfaces
{
    public interface IMeetingRepository
    {
        Task<List<Meeting>> GetAll();
        Task<Meeting> GetById(int id);
        Task Add(Meeting meeting);
        Task Update(Meeting meeting);
        Task Delete(Meeting meeting);
    }
}
