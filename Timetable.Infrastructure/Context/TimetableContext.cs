using System;
using System.Collections.Generic;
using System.Text;
using Timetable.Core.Models;
using Microsoft.EntityFrameworkCore;


namespace Timetable.Infrastructure.Context
{
    public class TimetableContext: DbContext
    {
        public TimetableContext(DbContextOptions<TimetableContext> options) : base(options) { }
        public DbSet<Classroom> Classroom { get; set; }
        public DbSet<Lesson> Lesson { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Teacher> Teacher { get; set; }
        public DbSet<Group> Group { get; set; }
        public DbSet<Day> Day { get; set; }
        public DbSet<Time> Time { get; set; }
    }
}
