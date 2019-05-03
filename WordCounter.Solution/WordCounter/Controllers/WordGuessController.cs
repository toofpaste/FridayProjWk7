using Microsoft.AspNetCore.Mvc;
using WordCounter;
using System.Collections.Generic;

namespace WordCounter.Controllers
{
    public class PlayController : Controller
    {

        [HttpGet("/Play")]
        public ActionResult WordGuess(Word newWord)
        {
            return View(newWord);
        }

        [HttpGet("/Play/new")]
        public ActionResult GuessForm()
        {
            Word.ClearAll();
            return View();
        }
        [HttpPost("/Play")]
        public ActionResult GuessForm(string word, int difficulty)
        {
            Word newWord = new Word("", word, difficulty);
            return View("WordGuess", newWord);
        }
    }
}