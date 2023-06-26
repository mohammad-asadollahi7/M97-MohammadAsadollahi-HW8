﻿using BankManagement.Models;
using BankManagement.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Net.NetworkInformation;
using System.Text.Json;


namespace BankManagement.Controllers;

public class HomeController : Controller
{
    private IHttpContextAccessor _context;
    private IUserService _userService;

    public HomeController(IUserService userService, 
                 IHttpContextAccessor context)
    {
        _context = context;
        _userService = userService;
    }
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Login(string NationalCode, string PhoneNumber)
    {
        var IsExist = _userService.CheckUser(NationalCode, PhoneNumber);

        if (!IsExist)
        {
            ViewBag.ErrorImg = "/icons/error.png";
            ViewBag.ErrorMessage = "ورودی نامعتبر";
            return View("index");
        }

        else
        {
            _context.HttpContext?.Session.SetString("NationalCode", NationalCode);
            return RedirectToAction("Account");
        }
    }

    public IActionResult Account()
    {
        return View();
    }

    public IActionResult Turnover(string NationalCode)
    {
        var user = _userService.GetUser(NationalCode);
        if (user.turnovers?.Count() == 0)
        {
            ViewBag.ErrorMessage = "عدم وجود گردش حساب";
            return View("Account");
        }
        else
        {
            return View(user);
        }
    }

    //public IActionResult Transaction()
    //{


    //}
}
