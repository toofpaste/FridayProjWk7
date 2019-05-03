using Microsoft.AspNetCore.Mvc;
using Scrabble;
using System.Collections.Generic;

namespace Scrabble.Controllers
{
    public class ScrabController : Controller
    {

        [HttpGet("/Scrab")]
        public ActionResult Show(Letters newWord)
        {
            return View(newWord);
        }

        [HttpGet("/Scrab/new")]
        public ActionResult WordForm()
        {
            return View();
        }
        [HttpPost("/Scrab")]
        public ActionResult WordForm(string word)
        {
            Letters newWord = new Letters(word);
            return View("Show", newWord);
        }
    }
}