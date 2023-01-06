using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Auth1.Controllers
{
    public class CoachController : Controller
    {
        [Authorize(Roles = "Coach")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
