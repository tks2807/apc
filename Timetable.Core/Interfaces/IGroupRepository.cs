using System;
using System.Collections.Generic;
using System.Text;
using Timetable.Core.Models;
using System.Threading.Tasks;


namespace Timetable.Core.Interfaces
{
    public interface IGroupRepository
    {
        Task<IEnumerable<Group>> GetAll();
        Task<List<Group>> GetGroup(int group);
    }
}
