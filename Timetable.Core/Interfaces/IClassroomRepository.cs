using System;
using System.Collections.Generic;
using System.Text;
using Timetable.Core.Models;
using System.Threading.Tasks;

namespace Timetable.Core.Interfaces
{
    public interface IClassroomRepository
    {
        Task<IEnumerable<Classroom>> GetAll();
        Task<List<Classroom>> GetClassroom(int classroomid);
    }
}
