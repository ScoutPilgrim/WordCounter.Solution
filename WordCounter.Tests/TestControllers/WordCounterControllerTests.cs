using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Controllers;
using WordCounter.Models;

namespace WordCounter.Tests
{
    [TestClass]
    public class WordCounterControllerTest
    {
      [TestMethod]
      public void IndexCorrectView_Test()
      {
        WordCounterController controller = new WordCounterController();
        ActionResult indexView = controller.Index();
        Assert.IsInstanceOfType(indexView, typeof(ViewResult));
      }
      [TestMethod]
      public void IndexCorrectModelType_RepeatCounterList()
      {
        WordCounterController controller = new WordCounterController();
        ViewResult indexView = Index() as ViewResult;

        var result = indexView.ViewData.Model;

        Assert.IsInstanceOfType(result, List<RepeatCounter>);
      }
      [TestMethod]
      public void NewCorrectView_Test()
      {
        WordCounterController controller = new WordCounterController();
        ActionResult indexView = controller.New();
        Assert.IsInstanceOfType(indexView, typeof(ViewResult));
      }
    }
}
