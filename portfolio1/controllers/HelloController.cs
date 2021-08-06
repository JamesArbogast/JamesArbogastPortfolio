using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace portfolio1.Controllers     //be sure to use your own project's namespace!
{
    public class HelloController : Controller   //remember inheritance??
    {
        //for each route this controller is to handle:
        [HttpGet]       //type of request
        [Route("")]     //associated route string (exclude the leading /)
        public ViewResult Index()
        {
          return View();
        }

        [HttpGet]
        [Route("/projects")]
        public ViewResult Projects()
        {
          return View("Projects");
        }

        [HttpGet]
        [Route("/contact")]
        public ViewResult Contact()
        {
          return View("Contact");
        }
    }
}