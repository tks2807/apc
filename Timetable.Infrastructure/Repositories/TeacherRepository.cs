using System;
using System.Collections.Generic;
using System.Text;
using Timetable.Infrastructure.Context;
using System.Threading.Tasks;
using Timetable.Core.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Timetable.Core.Interfaces;

namespace Timetable.Infrastructure.Repositories
{
    public class TeacherRepository: ITeacherRepository
    {
        private readonly TimetableContext context;
        public TeacherRepository(TimetableContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Teacher>> GetAll()
        {
            return await context.Teacher.OrderBy(x => x.Id).ToListAsync();
        }

        public async Task<List<Teacher>> GetTeacher(int teacherid)
        {
            var lessons = await context.Teacher.OrderBy(les => les.Id)
                .Where(les => les.Id == teacherid)
                .ToListAsync();
            return lessons;
        }
    }
}
