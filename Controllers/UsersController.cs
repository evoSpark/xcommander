using ArduinoXCommander.Models.UnitOfWork;
using System.Web.Http;

namespace ArduinoXCommander.Controllers
{
    public class UsersController : ApiController
    {
        private AuthorizationUnitOfWork _auth = new AuthorizationUnitOfWork();

        [Route("api/users/{username}/{password}")]
        [HttpGet]
        public IHttpActionResult GetSingle(string username, string password)
        {
            var result = _auth.Authorize(username, password);
            if (result == null)
            {
                return BadRequest();
            }
            return Ok(result);
        }
    }
}
