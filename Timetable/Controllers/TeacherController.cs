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
using Timetable.Core.Models;

namespace Timetable.Controllers
{
    [Route("api/teacher")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly ITeacherRepository TeacherRepository;
        private readonly IMapper Mapper;

        public TeacherController(ITeacherRepository teacherRepository, IMapper mapper)
        {
            TeacherRepository = teacherRepository;
            Mapper = mapper;
        }

        [HttpGet("getteachers")]
        public async Task<IActionResult> GetAllAsync()
        {
            var teachers = await TeacherRepository.GetAll();
            var teachersToReturn = Mapper.Map<IEnumerable<TeacherDTO>>(teachers);
            return teachers != null ? (IActionResult)Ok(teachersToReturn) : NoContent();
        }

        [HttpGet("id/{teacherid}")]
        public async Task<IActionResult> GetTeacherAsync(int teacherid)
        {
            var teachers = await TeacherRepository.GetTeacher(teacherid);
            var teachersToReturn = Mapper.Map<IEnumerable<TeacherDTO>>(teachers);
            return teachers != null ? (IActionResult)Ok(teachersToReturn) : NoContent();
        }

        [HttpPost("createteacher")]
        public async Task<IActionResult> CreateTeacher(Teacher teacher)
        {
            if (teacher == null)
            {
                return BadRequest();
            }
            await TeacherRepository.CreateTeacher(teacher);
            return Accepted();
        }
    }
}
