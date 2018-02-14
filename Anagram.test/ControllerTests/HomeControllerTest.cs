using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Anagram.Controllers;
using Anagram.Models;

namespace Anagram.Tests
{
  [TestClass]
  public class HomeControllerTest
  {
    [TestMethod]
    public void Index_ReturnCorrectView_True()
    {
      //arrange
      HomeController controller = new HomeController();

      //act
      IActionResult indexView = controller.Index();
      ViewResult result = indexView as ViewResult;

      //assert
      Assert.IsInstanceOfType(result, typeof(ViewResult));
    }

    //also passes if we pass no object for some reason.
    [TestMethod]
    public void Index_HasCorrectModelType_StringList()
    {
      //arrange
      ViewResult indexView = new HomeController().Index() as ViewResult;

      //act
      var result = indexView.ViewData.Model;

      //assert
      Assert.IsInstanceOfType(result, typeof(List<string>));
    }

    // [TestMethod]
    // public void Create_ReturnCorrectView_True()
    // {
    //   //arrange
    //   HomeController controller = new HomeController();
    //
    //   //act
    //   IActionResult indexView = controller.Create();
    //   ViewResult result = indexView as ViewResult;
    //
    //   //assert
    //   Assert.IsInstanceOfType(result, typeof(ViewResult));
    // }
    //
    // //also passes if we pass no object for some reason.
    // [TestMethod]
    // public void Create_HasCorrectModelType_True()
    // {
    //   //arrange
    //   ViewResult indexView = new HomeController().Create() as ViewResult;
    //   //act
    //   var result = indexView.ViewData.Model;
    //   //assert
    //   Assert.IsInstanceOfType(result, typeof(List<string>));
    // }
  }
}
