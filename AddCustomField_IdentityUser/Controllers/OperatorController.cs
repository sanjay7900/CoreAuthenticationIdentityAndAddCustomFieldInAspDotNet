using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AddCustomField_IdentityUser.Controllers
{
    [Authorize(Roles="Operator")]
    public class OperatorController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }
    }
}
