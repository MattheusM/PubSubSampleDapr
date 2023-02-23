using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dapr.Client;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Publisher.Controllers
{
   

    [ApiController]
    [Route("[controller]")]
    public class PublishController : ControllerBase
    {
        private readonly DaprClient _daprClient;
  

        public PublishController(DaprClient daprClient)
        {
            _daprClient = daprClient;
         
        }

        [HttpPost("messages")]
        public async Task<ActionResult> PublishMessageAsync([FromBody]string message)
        {
            var pubsubName = "mmunguia"; // Reemplaza con el nombre de tu pubsub
            var topicName = "mytopic1"; // Reemplaza con el nombre de tu topic

            await _daprClient.PublishEventAsync(pubsubName,topicName,message);
      
          
            return Ok();
        }
    }

}

