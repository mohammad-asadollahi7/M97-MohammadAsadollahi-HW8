using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BankManagement.Controllers;

public class HomeController : Controller
{
    public IActionResult Login()
    {

        return View();
    }
}
