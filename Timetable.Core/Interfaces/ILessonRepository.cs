using System;
using System.Collections.Generic;
using System.Text;
using Timetable.Core.Models;
using System.Threading.Tasks;

namespace Timetable.Core.Interfaces
{
    public interface ILessonRepository
    {
        Task<IEnumerable<Lesson>> GetAll();
        Task<List<Lesson>> GetLessonById(int lessonid);
        Task<List<Lesson>> GetLessonByGroup(int groupid);
        Task<List<Lesson>> GetLessonByTeacher(int teacherid);
        Task<List<Lesson>> GetLessonByClassroom(int classroomid);
    }
}
