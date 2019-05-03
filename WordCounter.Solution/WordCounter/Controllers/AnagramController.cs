using Microsoft.AspNetCore.Mvc;
using Anagram;
using System.Collections.Generic;

namespace Anagram.Controllers
{
    public class AnaController : Controller
    {

        [HttpGet("/Ana")]
        public ActionResult Show(AnaWord newWord)
        {
            return View(newWord);
        }

        [HttpGet("/Ana/new")]
        public ActionResult CreateForm()
        {
            return View();
        }
        [HttpPost("/Ana")]
        public ActionResult CreateForm(string firstWord, string word2)
        {
            AnaWord newWord = new AnaWord(firstWord, word2);
            return View("Show", newWord);
        }
    }
}