using ChainOfResponsibility.DAL;
using ChainOfResponsibility.Models;
using Microsoft.AspNetCore.Mvc;

namespace ChainOfResponsibility.Controllers
{
    public class SuccessController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
