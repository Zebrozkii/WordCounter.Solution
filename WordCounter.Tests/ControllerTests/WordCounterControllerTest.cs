using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Controllers;
using WordCounter;

namespace WordCounter.Tests
{
    [TestClass]
    public class WordCounterControllerTest
    {
      [TestMethod]
      public void Index_ReturnsCorrectView_True()
      {
        //Arrange
        WordCounterController controller = new WordCounterController();
        //Act
        ActionResult indexView = controller.Index();
        //Assert
        Assert.IsInstanceOfType(indexView, typeof(ViewResult));
      }
      [TestMethod]
      public void NewViewWorks()
      {
        WordCounterController controller = new WordCounterController();

        ActionResult NewView = controller.New();

        Assert.IsInstanceOfType(NewView,typeof(ViewResult));
      }

    }
}
