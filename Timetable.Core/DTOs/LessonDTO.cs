using System;
using System.Collections.Generic;
using System.Text;
using Timetable.Core.Models;

namespace Timetable.Core.DTOs
{
    public class LessonDTO
    {
        public int Id { get; set; }
        public Discipline Discipline { get; set; }
        public int? DisciplineId { get; set; }
        public Classroom Classroom { get; set; }
        public int? ClassroomId { get; set; }
        public Teacher Teacher { get; set; }
        public int? TeacherId { get; set; }
        public Group Group { get; set; }
        public int GroupId { get; set; }
        public Day Day { get; set; }
        public int DayId { get; set; }
        public Time Time { get; set; }
        public int TimeId { get; set; }
    }
}
