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
    public class UserRoleController : Controller
    {
        private IUserRoleService _userRoleService;

        public UserRoleController(IUserRoleService userRoleService)
        {
            _userRoleService = userRoleService;
        }

        [HttpGet("getall")]
        //[Authorize(Roles="userRole.List")]
        public IActionResult GetList()
        {
            var result = _userRoleService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }



        [HttpGet("getbyid")]
        public IActionResult GetById(int userRoleId)
        {
            var result = _userRoleService.GetById(userRoleId);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }
        [EnableCors("AllowOrigin")]
        [HttpPost("add")]
        public IActionResult Add(UserRole userRole)
        {
            var result = _userRoleService.Add(userRole);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("update")]
        public IActionResult Update(UserRole userRole)
        {
            var result = _userRoleService.Update(userRole);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("delete")]
        public IActionResult Delete(UserRole userRole)
        {
            var result = _userRoleService.Delete(userRole);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }
    }
}
