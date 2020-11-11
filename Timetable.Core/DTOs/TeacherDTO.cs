using System;
using System.Collections.Generic;
using System.Text;
using Timetable.Core.Models;

namespace Timetable.Core.DTOs
{
    public class TeacherDTO
    {
        public int Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Position { get; set; }
        public string Email { get; set; }
    }
}