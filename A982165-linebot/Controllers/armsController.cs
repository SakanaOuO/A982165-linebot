using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace A982165_linebot.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class armsController : ControllerBase
    {
        // GET: api/arms
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/arms/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/arms
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/arms/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/arms/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
