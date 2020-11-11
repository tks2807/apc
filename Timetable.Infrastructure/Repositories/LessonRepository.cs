using System;
using System.Collections.Generic;
using System.Text;
using Timetable.Core.Interfaces;
using Timetable.Infrastructure.Context;
using System.Threading.Tasks;
using Timetable.Core.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Timetable.Infrastructure.Repositories
{
    public class LessonRepository: ILessonRepository
    {
        private readonly TimetableContext context;
        public LessonRepository(TimetableContext context)
        {
            this.context = context;
        }
        public async Task<IEnumerable<Lesson>> GetAll()
        {
            return await context.Lesson.OrderBy(x => x.Id)
                .Include(les => les.Group)
                .Include(les => les.Teacher)
                .Include(les => les.Classroom)
                .Include(les => les.Day)
                .Include(les => les.Time)
                .ToListAsync();
        }
        public async Task<List<Lesson>> GetLessonById(int lessonid)
        {
            var lessons = await context.Lesson.Where(les => les.Id == lessonid)
                .Include(les => les.Group)
                .Include(les => les.Teacher)
                .Include(les => les.Classroom)
                .Include(les => les.Day)
                .Include(les => les.Time)
                .ToListAsync();
            return lessons;
        }
        public async Task<List<Lesson>> GetLessonByGroup(int groupid)
        {
            var lessons = await context.Lesson.OrderBy(les => les.Id)
                .Where(les => les.GroupId == groupid)
                .Include(les => les.Group)
                .Include(les => les.Teacher)
                .Include(les => les.Classroom)
                .Include(les => les.Day)
                .Include(les => les.Time)
                .ToListAsync();
            return lessons;
        }
        public async Task<List<Lesson>> GetLessonByTeacher(int teacherid)
        {
            var lessons = await context.Lesson.Where(les => les.TeacherId == teacherid)
                .Include(les => les.Group)
                .Include(les => les.Teacher)
                .Include(les => les.Classroom)
                .Include(les => les.Day)
                .Include(les => les.Time)
                .ToListAsync();
            return lessons;
        }
        public async Task<List<Lesson>> GetLessonByClassroom(int classroomid)
        {
            var lessons = await context.Lesson.Where(les => les.ClassroomId == classroomid)
                .Include(les => les.Group)
                .Include(les => les.Teacher)
                .Include(les => les.Classroom)
                .Include(les => les.Day)
                .Include(les => les.Time)
                .ToListAsync();
            return lessons;
        }
    }
}
