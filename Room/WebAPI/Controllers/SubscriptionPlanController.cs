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
    public class SubscriptionPlanController : Controller
    {
        private ISubscriptionPlanService _subscriptionPlanService;

        public SubscriptionPlanController(ISubscriptionPlanService subscriptionPlanService)
        {
            _subscriptionPlanService = subscriptionPlanService;
        }

        [HttpGet("getall")]
        //[Authorize(Roles="subscriptionPlan.List")]
        public IActionResult GetList()
        {
            var result = _subscriptionPlanService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }



        [HttpGet("getbyid")]
        public IActionResult GetById(int subscriptionPlanId)
        {
            var result = _subscriptionPlanService.GetById(subscriptionPlanId);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }
        [EnableCors("AllowOrigin")]
        [HttpPost("add")]
        public IActionResult Add(SubscriptionPlan subscriptionPlan)
        {
            var result = _subscriptionPlanService.Add(subscriptionPlan);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("update")]
        public IActionResult Update(SubscriptionPlan subscriptionPlan)
        {
            var result = _subscriptionPlanService.Update(subscriptionPlan);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("delete")]
        public IActionResult Delete(SubscriptionPlan subscriptionPlan)
        {
            var result = _subscriptionPlanService.Delete(subscriptionPlan);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }
    }
}
