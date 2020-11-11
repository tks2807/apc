﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Timetable.Core.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string MoodleId { get; set; }
        public string Email { get; set; }
        public Group Group { get; set; }
        public int GroupId { get; set; }
    }
}
