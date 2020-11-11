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
    public class ClassroomRepository: IClassroomRepository
    {
        private readonly TimetableContext context;
        public ClassroomRepository(TimetableContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Classroom>> GetAll()
        {
            return await context.Classroom.OrderBy(x => x.Id).ToListAsync();
        }

        public async Task<List<Classroom>> GetClassroom(int classroomid)
        {
            var lessons = await context.Classroom.OrderBy(les => les.Id)
                .Where(les => les.Id == classroomid)
                .ToListAsync();
            return lessons;
        }
    }
}
