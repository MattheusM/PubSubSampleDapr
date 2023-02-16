using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dapr;
using Dapr.Client;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Subscriber.Controllers
{
    

    [ApiController]
    [Route("[controller]")]
    public class MessageController : ControllerBase
    {
        [Topic("nombre-de-tu-pubsub", "nombre-de-tu-topic")] // Reemplaza con el nombre de tu pubsub y topic
        [HttpPost("messages")]
        public IActionResult HandleMessageAsync([FromBody] string message)
        {
            Console.WriteLine(message);

            return Ok();
        }
    }

}

