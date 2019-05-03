using Microsoft.AspNetCore.Mvc;
using RockPaperScissors;
using System.Collections.Generic;

namespace RockPaperScissors.Controllers
{
    public class RPSController : Controller
    {

        [HttpGet("/RPS")]
        public ActionResult ShowR(rpsLogic newWord)
        {
            return View(newWord);
        }

        [HttpGet("/RPS/new")]
        public ActionResult FormR()
        {
            return View();
        }
        [HttpPost("/RPS")]
        public ActionResult FormR(string word)
        {
            rpsLogic newWord = new rpsLogic(word);
            return View("ShowR", newWord);
        }
    }
}