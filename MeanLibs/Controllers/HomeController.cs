using Microsoft.AspNetCore.Mvc;
using MeanLibs.Models;

namespace MeanLibs.Controllers
{
  public class HomeController : Controller
  {
    // [Route("/")]
    // public ActionResult Quotes()
    // {
    //   QuotesVariable myQuotesVariable = new QuotesVariable();
    //   return View(myQuotesVariable);
    // }

    [Route("/")]
    public ActionResult Form() { return View(); }

    [Route("/meanquotes")]
    public ActionResult MeanQuotes(string adjective, string dayOfTheWeek, string color, string noun, string slang, string verb)
    {
      QuotesVariable myQuotesVariable = new QuotesVariable();
      myQuotesVariable.Adjective = adjective;
      myQuotesVariable.DayOfTheWeek = dayOfTheWeek;
      myQuotesVariable.Color = color;
      myQuotesVariable.Profession = profession;
      myQuotesVariable.Slang = slang;
      myQuotesVariable.Verb = verb;

      return View(myQuotesVariable);
    }
  }
}
