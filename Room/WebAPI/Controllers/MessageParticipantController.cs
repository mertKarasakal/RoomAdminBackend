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
    public class MessageParticipantController : Controller
    {
        private IMessageParticipantService _messageParticipantService;

        public MessageParticipantController(IMessageParticipantService messageParticipantService)
        {
            _messageParticipantService = messageParticipantService;
        }

        [HttpGet("getall")]
        //[Authorize(Roles="messageParticipant.List")]
        public IActionResult GetList()
        {
            var result = _messageParticipantService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }



        [HttpGet("getbyid")]
        public IActionResult GetById(int messageParticipantId)
        {
            var result = _messageParticipantService.GetById(messageParticipantId);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }
        [EnableCors("AllowOrigin")]
        [HttpPost("add")]
        public IActionResult Add(MessageParticipant messageParticipant)
        {
            var result = _messageParticipantService.Add(messageParticipant);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("update")]
        public IActionResult Update(MessageParticipant messageParticipant)
        {
            var result = _messageParticipantService.Update(messageParticipant);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("delete")]
        public IActionResult Delete(MessageParticipant messageParticipant)
        {
            var result = _messageParticipantService.Delete(messageParticipant);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }
    }
}
