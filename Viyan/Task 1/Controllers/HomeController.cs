using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Task_1.Models;
using System.ComponentModel.DataAnnotations;

namespace Task_1.Controllers;

public class HomeController : Controller
{

    private readonly IRespository _respository;

    public HomeController(IRespository respository)
    {
        _respository = respository;
    }
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(User user)
    {
        if(ModelState.IsValid){
            _respository.AddDetails(user);
            // return RedirectToAction("Privacy");}
        }
        return View();
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
