using Microsoft.AspNetCore.Mvc;

namespace BankManagement.Controllers;

public class HomeController : Controller
{
    public IActionResult Login()
    {
        return View();
    }
}
