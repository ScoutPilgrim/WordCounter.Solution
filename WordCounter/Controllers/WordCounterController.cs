using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;
using System.Collections.Generic;

namespace WordCounter.Controllers
{
  public class WordCounterController : Controller
  {
    [HttpGet("/wordcounter")]
    public ActionResult Index()
    {
      List<RepeatCounter> allRepeatCounters = RepeatCounter.GetAll();
      return View(allRepeatCounters);
    }

    [HttpGet("/wordcounter/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpGet("/wordcounter/{id}")]
    public ActionResult Show(int id)
    {
      RepeatCounter repeatCounter = RepeatCounter.Find(id);
      return View(repeatCounter);
    }
    [HttpPost("/wordcounter/delete")]
    public ActionResult DeleteAll()
    {
      RepeatCounter.ClearAll();
      return View();
    }
  }
}
