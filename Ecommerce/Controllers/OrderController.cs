using Ecommerce.Models;
using Ecommerce.Utility;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }
        


    }
}
