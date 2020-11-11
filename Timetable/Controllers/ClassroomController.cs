using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Timetable.Core.Interfaces;
using Timetable.Core;
using Timetable.Infrastructure;
using AutoMapper;
using Timetable.Core.DTOs;

namespace Timetable.Controllers
{
    [Route("api/classroom")]
    [ApiController]
    public class ClassroomController : ControllerBase
    {
        private readonly IClassroomRepository ClassroomRepository;
        private readonly IMapper Mapper;

        public ClassroomController(IClassroomRepository classroomRepository, IMapper mapper)
        {
            ClassroomRepository = classroomRepository;
            Mapper = mapper;
        }

        [HttpGet("getclassrooms")]
        public async Task<IActionResult> GetAllAsync()
        {
            var classrooms = await ClassroomRepository.GetAll();
            var classroomsToReturn = Mapper.Map<IEnumerable<ClassroomDTO>>(classrooms);
            return classrooms != null ? (IActionResult)Ok(classroomsToReturn) : NoContent();
        }

        [HttpGet("id/{classroomid}")]
        public async Task<IActionResult> GetTeacherAsync(int classroomid)
        {
            var classrooms = await ClassroomRepository.GetClassroom(classroomid);
            var classroomsToReturn = Mapper.Map<IEnumerable<ClassroomDTO>>(classrooms);
            return classrooms != null ? (IActionResult)Ok(classroomsToReturn) : NoContent();
        }
    }
}
