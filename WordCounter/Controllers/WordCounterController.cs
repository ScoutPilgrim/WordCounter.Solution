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
  }
}
