using ArduinoXCommander.Models;
using System;
using System.Net.Http;
using System.Web.Mvc;

namespace ArduinoXCommander.Controllers
{
    public class LoginController : Controller
    {
        private static string USERS_API_URI = "http://localhost:62496/api/";
        // GET: Login
        [HttpGet]
        [Route("Login")]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            string apiRoute = String.Format("users/{0}/{1}", username, password);
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(USERS_API_URI);

                using (var response = client.GetAsync(apiRoute))
                {
                    var result = response.Result;

                    if (result.IsSuccessStatusCode)
                    {
                        var content = result.Content.ReadAsAsync<User>();

                        return Json(content.Result);
                    }
                }
            }
            ModelState.AddModelError("Error", "Unable to auhtorize");
            return View();
        }
    }
}