using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dapr;
using Dapr.Client;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Subscriber.Controllers
{
    

    [ApiController]
    [Route("[controller]")]
    public class MessageController : ControllerBase
    {


        private readonly ILogger<MessageController> _logger;

        public MessageController(ILogger<MessageController> logger)
        {
            _logger = logger;
        }


        [Topic("pubsub", "mytopic")] // Reemplaza con el nombre de tu pubsub y topic
        [HttpPost("mytopic")]
        public void HandleMessageAsync([FromBody] string message)
        {
            _logger.LogInformation("Subscriber received : " + message);


        }
    }

}

