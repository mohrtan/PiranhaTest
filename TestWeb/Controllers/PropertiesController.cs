using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Piranha;
using Piranha.Areas.Manager.Controllers;
using Piranha.Manager;

namespace PiranhaTest.Controllers
{
    [Area("Manager")]
    public class PropertiesController : ManagerAreaControllerBase
    {
        public PropertiesController(IApi api) : base(api)
        {
        }

        [Route("manager/properties")]
        [Authorize(Policy = Permission.Pages)]
        public IActionResult PropertyList()
        {
            return View();
        }
    }
}
