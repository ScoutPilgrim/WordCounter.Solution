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
        ViewResult indexView = controller.Index() as ViewResult;

        var result = indexView.ViewData.Model;

        Assert.IsInstanceOfType(result, typeof(List<RepeatCounter>));
      }
      [TestMethod]
      public void NewCorrectView_Test()
      {
        WordCounterController controller = new WordCounterController();
        ActionResult indexView = controller.New();
        Assert.IsInstanceOfType(indexView, typeof(ViewResult));
      }
      [TestMethod]
      public void ShowCorrectView_Test()
      {
        WordCounterController controller = new WordCounterController();
        RepeatCounter repeatCounter = new RepeatCounter("test", "test");
        int id = repeatCounter.GetId();
        ActionResult indexView = controller.Show(id);
        Assert.IsInstanceOfType(indexView, typeof(ViewResult));
      }
      [TestMethod]
      public void ShowCorrectModelType_RepeatCounter()
      {
        WordCounterController controller = new WordCounterController();
        RepeatCounter repeatCounter = new RepeatCounter("test", "test");
        int id = repeatCounter.GetId();
        ViewResult indexView = controller.Show(id) as ViewResult;

        var result = indexView.ViewData.Model;

        Assert.IsInstanceOfType(result, typeof(RepeatCounter));
      }
      [TestMethod]
      public void DeleteAllCorrectView_Test()
      {
        WordCounterController controller = new WordCounterController();
        ActionResult indexView = controller.DeleteAll();
        Assert.IsInstanceOfType(indexView, typeof(ViewResult));
      }
    }
}
