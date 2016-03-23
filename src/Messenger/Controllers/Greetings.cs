using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Messenger.Services;
using Microsoft.AspNet.Mvc;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Messenger.Controllers
{
    [Route("api/[controller]")]
    public class Greetings : Controller
    {
        IGreetingService _greeter;

        public Greetings(IGreetingService greeter)
        {
            _greeter = greeter;
        }
        // GET: api/values
        [HttpGet]
        public GreetingMessage Get()
        {
            var model = _greeter.GetTodaysGreeting();
            return model;
        }

        

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
