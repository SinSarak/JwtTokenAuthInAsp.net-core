﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TokenAuthDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class EmployeeController : ControllerBase
    {
        public IActionResult Get()
        {
            return Ok(new string[] {"Employee one", "Employee two", "Employee three" });
        }
    }
}