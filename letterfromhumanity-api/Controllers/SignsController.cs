using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using letterfromhumanityapi.Models;

namespace letterfromhumanity_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SignsController : ControllerBase
    {
        // GET api/signs
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // POST api/signs
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}
        [HttpPost]
        public async Task<IActionResult> Create([Bind("FirstName, LastName, Email, Country")] Sign sign)
        {
            using (var context = new ApiContext())
            {
                context.Add(sign);
                await context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
        }
    }
}
