using Microsoft.AspNetCore.Mvc;
using LeetSpeak;
using System.Collections.Generic;

namespace LeetSpeak.Controllers
{
    public class LeetController : Controller
    {

        [HttpGet("/Leet")]
        public ActionResult ShowL(LeetSpeak newWord)
        {
            return View(newWord);
        }

        [HttpGet("/Leet/new")]
        public ActionResult FormL()
        {
            return View();
        }
        [HttpPost("/Leet")]
        public ActionResult FormL(string firstWord)
        {
            LeetSpeak newWord = new LeetSpeak(firstWord);
            return View("ShowL", newWord);
        }
    }
}