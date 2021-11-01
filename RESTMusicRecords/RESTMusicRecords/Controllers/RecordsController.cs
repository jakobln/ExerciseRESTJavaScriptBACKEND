using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using RESTMusicRecords.Managers;
using RESTMusicRecords.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace RESTMusicRecords.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecordsController : ControllerBase
    {
        private readonly RecordsManager _manager = new RecordsManager();


        // GET: api/<ItemsController>
        [HttpGet]
        public IEnumerable<Records> Get([FromQuery] string substring)
        {
            return _manager.GetAll(substring);
        }

    }
}
