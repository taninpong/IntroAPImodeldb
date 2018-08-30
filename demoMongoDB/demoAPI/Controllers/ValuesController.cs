using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace demoAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        
        [HttpGet("{first}/{second}")]
        public string CalculateNumber(int first, int second)
        {
            return (first + second).ToString();
        }
        
        [HttpGet("{first}/{second}")]
        public string Plus(int first, int second)
        {
            return (first + second).ToString();
        }
        
        // POST api/values
        [HttpPost]
        public void Post([FromBody]Student value)
        {
            // TODO: Implement
        }

        // PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        // DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }

    public class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }
    }
}
