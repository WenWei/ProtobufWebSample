using Microsoft.AspNetCore.Mvc;
using ProtobufWeb.ProtoGen;

namespace ProtobufWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EchoController : ControllerBase
    {
        // POST api/Echo
        [HttpPost]
        public ActionResult<EchoData> Post([FromBody] EchoData value)
        {
            value.Text = $"ECHO: {value.Text}";
            return value;
        }
    }
}
