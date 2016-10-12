using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Samples.AspCoreEF.DAL.EF.EntityFrameworkContext;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Samples.AspCoreEF.Controllers
{
    [Route("api/persons")]
    public class PersonController : Controller
    {
        private TaskSystemDbContext _taskContext;

        public PersonController(TaskSystemDbContext taskContext)
        {
            _taskContext = taskContext;
        }
        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            //List<Person> list1 = new List<Person>();
            //foreach (var person in _taskContext.Persons)
            //    list1.Add(person);
            //var list = list1.Select(p => p.Name);
            //return list;
           
            var list = _taskContext.Persons.ToList().Select(p=>p.Name);
            return list;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
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
