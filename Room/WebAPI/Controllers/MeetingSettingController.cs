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
    public class MeetingSettingController : Controller
    {
        private IMeetingSettingService _meetingSettingService;

        public MeetingSettingController(IMeetingSettingService meetingSettingService)
        {
            _meetingSettingService = meetingSettingService;
        }

        [HttpGet("getall")]
        //[Authorize(Roles="meetingSetting.List")]
        public IActionResult GetList()
        {
            var result = _meetingSettingService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }



        [HttpGet("getbyid")]
        public IActionResult GetById(int meetingSettingId)
        {
            var result = _meetingSettingService.GetById(meetingSettingId);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }
        [EnableCors("AllowOrigin")]
        [HttpPost("add")]
        public IActionResult Add(MeetingSetting meetingSetting)
        {
            var result = _meetingSettingService.Add(meetingSetting);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("update")]
        public IActionResult Update(MeetingSetting meetingSetting)
        {
            var result = _meetingSettingService.Update(meetingSetting);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("delete")]
        public IActionResult Delete(MeetingSetting meetingSetting)
        {
            var result = _meetingSettingService.Delete(meetingSetting);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }
    }
}
