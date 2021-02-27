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
    public class UserPreferenceController : Controller
    {
        private IUserPreferenceService _userPreferenceService;

        public UserPreferenceController(IUserPreferenceService userPreferenceService)
        {
            _userPreferenceService = userPreferenceService;
        }

        [HttpGet("getall")]
        //[Authorize(Roles="userPreference.List")]
        public IActionResult GetList()
        {
            var result = _userPreferenceService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }



        [HttpGet("getbyid")]
        public IActionResult GetById(int userPreferenceId)
        {
            var result = _userPreferenceService.GetById(userPreferenceId);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }
        [EnableCors("AllowOrigin")]
        [HttpPost("add")]
        public IActionResult Add(UserPreference userPreference)
        {
            var result = _userPreferenceService.Add(userPreference);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("update")]
        public IActionResult Update(UserPreference userPreference)
        {
            var result = _userPreferenceService.Update(userPreference);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("delete")]
        public IActionResult Delete(UserPreference userPreference)
        {
            var result = _userPreferenceService.Delete(userPreference);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }
    }
}
