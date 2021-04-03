using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.AspNetCore.Cors;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserOperationClaimController : Controller
    {
        private IUserOperationClaimService _userOperationClaimService;

        public UserOperationClaimController(IUserOperationClaimService userOperationClaimService)
        {
            _userOperationClaimService = userOperationClaimService;
        }

        [HttpGet("getall")]
        //[Authorize(Roles="operationClaim.List")]
        public IActionResult GetList()
        {
            var result = _userOperationClaimService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }



        [HttpGet("getbyid")]
        public IActionResult GetById(int operationClaimId)
        {
            var result = _userOperationClaimService.GetById(operationClaimId);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }
        [EnableCors("AllowOrigin")]
        [HttpPost("add")]
        public IActionResult Add(UserOperationClaim userOperationClaim)
        {
            var result = _userOperationClaimService.Add(userOperationClaim);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("update")]
        public IActionResult Update(UserOperationClaim userOperationClaim)
        {
            var result = _userOperationClaimService.Update(userOperationClaim);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("delete")]
        public IActionResult Delete(UserOperationClaim userOperationClaim)
        {
            var result = _userOperationClaimService.Delete(userOperationClaim);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }
    }
}
