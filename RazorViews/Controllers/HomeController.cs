using Microsoft.AspNetCore.Mvc;
using RazorViews.Models;
namespace RazorViews.Controllers;

public class HomeController : Controller
{
    [Route("home")]
    public IActionResult Index()
    {
        ViewData["appTitle"] = "Asp.Net Core App";
        List<Person> people = new List<Person>
        {
        new Person { Name = "John", DateOfBirth = DateTime.Parse("2027-05-05") },
        new Person { Name = "Jane", DateOfBirth = DateTime.Parse("2027-05-05") }
        };
        ViewData["people"] = people;
        return View(); 
        //Views/Home/Index.cshtml
        //return View("abc"); //abc.cshtml
        //return new ViewResult() { ViewName = "abc" };
    }
}
