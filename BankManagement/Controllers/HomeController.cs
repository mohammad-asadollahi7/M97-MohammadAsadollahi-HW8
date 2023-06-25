using BankManagement.Models;
using BankManagement.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BankManagement.Controllers;

public class HomeController : Controller
{
    private IUserService _userService;

    public HomeController(IUserService userService)
    {
        _userService = userService;
    }
    public IActionResult Index()
    {
        return View(); 
    }
    public IActionResult Login(string NationalCode, string PhoneNumber)
    {
        var isValid = _userService.IsValid(NationalCode, PhoneNumber);
        if(isValid)
        {
            return RedirectToAction();
        }
        else
        {
            ViewBag.ErrorImg = "/icons/error.png";
            ViewBag.ErrorMessage="ورودی های نامعتبر";
            return View("index");
        }
    }


}
