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
      List<string> fakeList = new List<string>{};
      return View(fakeList);
    }

    [HttpPost("/submit")]
    public ActionResult Create()
    {
      string userWord = Request.Form["user-word"];
      List<string> userList = new List<string>{
        Request.Form["list-word1"],
        Request.Form["list-word2"],
        Request.Form["list-word3"],
        Request.Form["list-word4"],
        Request.Form["list-word5"]
      };
      AnagramChecker newAnagram = new AnagramChecker(userWord, userList);
      newAnagram.SetReturnList();
      List<string> returnList = newAnagram.GetReturnList();
      return View("Index", returnList);
    }
  }
}
