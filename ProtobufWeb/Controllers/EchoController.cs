using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ProtobufWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EchoController : ControllerBase
    {
        // POST api/Echo
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }
    }
}
