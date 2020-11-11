using System;
using System.Collections.Generic;
using System.Text;
using Timetable.Core.Models;
using System.Threading.Tasks;

namespace Timetable.Core.Interfaces
{
    public interface ITeacherRepository
    {
        Task<IEnumerable<Teacher>> GetAll();
        Task<List<Teacher>> GetTeacher(int teacherid);
    }
}
