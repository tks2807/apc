using System;
using System.Collections.Generic;
using System.Text;

namespace Timetable.Core.Models
{
    public class Classroom
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public string Block { get; set; }
        public int Floor { get; set; }
        public string Type { get; set; }
        public int Capacity { get; set; }
    }
}
