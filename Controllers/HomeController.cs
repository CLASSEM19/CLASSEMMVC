using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CLASSEM_MVC_PRO.Models;
using CLASSEM_MVC_PRO.Services.Interfaces;
using CLASSEM_MVC_PRO.Models.DTOs.UserDTOs;

namespace CLASSEM_MVC_PRO.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IUserService _user;
    public HomeController(IUserService user, ILogger<HomeController> logger)
    {
        _user = user;
        _logger = logger;
    }
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Signup()
    {

        return View();
    }
    public IActionResult Login()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Login(LoginRequestModel loginDetails)
    {
        if (loginDetails == null)
        {
            return NotFound();
        }
        var user = _user.Login(loginDetails);
        if (user == null)
        {
            return BadRequest();
        }
        else if (user.Data.Role == Enums.UserRoleType.Admin)
        {
            return RedirectToAction("DashBoard", "Attendant");
        }
        else if (user.Data.Role == Enums.UserRoleType.Customer)
        {
            return RedirectToAction("Index", "Customer");
        }
        else
        {
            return RedirectToAction("Index", "Home");
        }
    }
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
