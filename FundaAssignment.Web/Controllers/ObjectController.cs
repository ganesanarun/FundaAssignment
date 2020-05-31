using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FundaAssignment.Entities;
using FundaAssignment.Services;

namespace FundaAssignment.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ObjectController : ControllerBase
    {
        private IObjectService _objectService;
        public ObjectController(IObjectService objectService)
        {
            _objectService = objectService;
        }
        public async IActionResult GetObjects()
        {
            var objects = await _objectService.GetTop10MakelaarsInAmsterdam();
            return Ok(objects);
        }
    }
}
