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
    [Route("api/group")]
    [ApiController]
    public class GroupController : ControllerBase
    {
        private readonly IGroupRepository GroupRepository;
        private readonly IMapper Mapper;

        public GroupController(IGroupRepository groupRepository, IMapper mapper)
        {
            GroupRepository = groupRepository;
            Mapper = mapper;
        }

        [HttpGet("getgroups")]
        public async Task<IActionResult> GetAllAsync()
        {
            var groups = await GroupRepository.GetAll();
            var groupsToReturn = Mapper.Map<IEnumerable<GroupDTO>>(groups);
            return groups != null ? (IActionResult)Ok(groupsToReturn) : NoContent();
        }

        [HttpGet("id/{groupid}")]
        public async Task<IActionResult> GetGroupAsync(int groupid)
        {
            var groups = await GroupRepository.GetGroup(groupid);
            var groupsToReturn = Mapper.Map<IEnumerable<GroupDTO>>(groups);
            return groups != null ? (IActionResult)Ok(groupsToReturn) : NoContent();
        }
    }
}
