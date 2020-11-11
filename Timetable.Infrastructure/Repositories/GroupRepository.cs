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
    public class GroupRepository: IGroupRepository
    {
        private readonly TimetableContext context;
        public GroupRepository(TimetableContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Group>> GetAll()
        {
            return await context.Group.OrderBy(x => x.Id).ToListAsync();
        }

        public async Task<List<Group>> GetGroup(int groupid)
        {
            var lessons = await context.Group.OrderBy(les => les.Id)
                .Where(les => les.Id == groupid)
                .ToListAsync();
            return lessons;
        }


    }
}
