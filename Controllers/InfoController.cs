using System.Web.Http;

namespace ArduinoXCommander.Controllers
{
    public class InfoController : ApiController
    {
        [Route("Info")]
        public object Get()
        {
            return ServiceConfiguration.AsJson;
        }
    }
}
