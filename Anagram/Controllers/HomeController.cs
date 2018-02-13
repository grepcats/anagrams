using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Anagram.Models;

namespace Anagram.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpPost("/submit")]
    public ActionResult Create()
    {
       return View("Index");
    }
  }
}
