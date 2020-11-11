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
    [Route("api/timetable")]
    [ApiController]
    public class LessonController : ControllerBase
    {
        private readonly ILessonRepository LessonRepository;
        private readonly IMapper Mapper;
        public LessonController(ILessonRepository lessonRepository, IMapper mapper)
        {
            LessonRepository = lessonRepository;
            Mapper = mapper;
        }
        [HttpGet("getlessons")]
        public async Task<IActionResult> GetAllAsync()
        {
            var lessons = await LessonRepository.GetAll();
            var lessonsToReturn = Mapper.Map<IEnumerable<LessonDTO>>(lessons);
            return lessons != null ? (IActionResult)Ok(lessonsToReturn) : NoContent();
        }
        [HttpGet("id/{lessonid}")]
        public async Task<IActionResult> GetLessonByIdAsync(int lessonid)
        {
            var lessons = await LessonRepository.GetLessonById(lessonid);
            var lessonsToReturn = Mapper.Map<IEnumerable<LessonDTO>>(lessons);
            return lessons != null ? (IActionResult)Ok(lessonsToReturn) : NoContent();
        }
        [HttpGet("group/{groupid}")]
        public async Task<IActionResult> GetLessonByGroupAsync(int groupid)
        {
            var lessons = await LessonRepository.GetLessonByGroup(groupid);
            var lessonsToReturn = Mapper.Map<IEnumerable<LessonDTO>>(lessons);
            return lessons != null ? (IActionResult)Ok(lessonsToReturn) : NoContent();
        }
        [HttpGet("teacher/{teacherid}")]
        public async Task<IActionResult> GetLessonByTeacherAsync(int teacherid)
        {
            var lessons = await LessonRepository.GetLessonByTeacher(teacherid);
            var lessonsToReturn = Mapper.Map<IEnumerable<LessonDTO>>(lessons);
            return lessons != null ? (IActionResult)Ok(lessonsToReturn) : NoContent();
        }
        [HttpGet("classroom/{classroomid}")]
        public async Task<IActionResult> GetLessonByClassroomAsync(int classroomid)
        {
            var lessons = await LessonRepository.GetLessonByClassroom(classroomid);
            var lessonsToReturn = Mapper.Map<IEnumerable<LessonDTO>>(lessons);
            return lessons != null ? (IActionResult)Ok(lessonsToReturn) : NoContent();
        }
    }
}
