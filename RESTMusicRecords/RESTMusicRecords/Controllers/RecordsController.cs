using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using RESTMusicRecords.Managers;
using RESTMusicRecords.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RouteAttribute = Microsoft.AspNetCore.Components.RouteAttribute;

namespace RESTMusicRecords.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly RecordsManager _manager = new RecordsManager();


        // GET: api/<ItemsController>
        [HttpGet]
        public IEnumerable<Records> Get([FromQuery] string substring)
        {
            return _manager.GetAll(substring);
        }

        // GET api/<ItemsController>/5
        [HttpGet("{id}")]
        public Records Get(int id)
        {
            return _manager.GetById(id);
        }

        // POST api/<ItemsController>
        [HttpPost]
        public Records Post([FromBody] Records value)
        {
            return _manager.Add(value);
        }

        // PUT api/<ItemsController>/5
        [HttpPut("{id}")]
        public Records Put(int id, [FromBody] Records value)
        {
            return _manager.Update(id, value);
        }

        // DELETE api/<ItemsController>/5
        [HttpDelete("{id}")]
        public Records Delete(int id)
        {
            return _manager.Delete(id);
        }
    }
}
