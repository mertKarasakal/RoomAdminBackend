using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Cors;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeetingParticipantController : Controller
    {
        private IMeetingParticipantService _meetingParticipantService;

        public MeetingParticipantController(IMeetingParticipantService meetingParticipantService)
        {
            _meetingParticipantService = meetingParticipantService;
        }

        [HttpGet("getall")]
        //[Authorize(Roles="meetingParticipant.List")]
        public IActionResult GetList()
        {
            var result = _meetingParticipantService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }



        [HttpGet("getbyid")]
        public IActionResult GetById(int meetingParticipantId)
        {
            var result = _meetingParticipantService.GetById(meetingParticipantId);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }
        [EnableCors("AllowOrigin")]
        [HttpPost("add")]
        public IActionResult Add(MeetingParticipant meetingParticipant)
        {
            var result = _meetingParticipantService.Add(meetingParticipant);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("update")]
        public IActionResult Update(MeetingParticipant meetingParticipant)
        {
            var result = _meetingParticipantService.Update(meetingParticipant);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("delete")]
        public IActionResult Delete(MeetingParticipant meetingParticipant)
        {
            var result = _meetingParticipantService.Delete(meetingParticipant);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }
    }
}
