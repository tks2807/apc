using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Timetable.Core.Models;
using Timetable.Core.DTOs;

namespace Timetable.Core.Helpers
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Lesson, LessonDTO>();
            CreateMap<Teacher, TeacherDTO>();
            CreateMap<Group, GroupDTO>();
            CreateMap<Classroom, ClassroomDTO>();
        }
    }
}
