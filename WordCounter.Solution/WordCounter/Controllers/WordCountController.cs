using Microsoft.AspNetCore.Mvc;
using WordCounter;
using System.Collections.Generic;

namespace WordCounter.Controllers
{
    public class WordController : Controller
    {
        [HttpGet("/Index")]
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet("/Index/New")]
        public ActionResult CreateForm()
        {
            return View();
        }
        [HttpPost("/Index")]
        public ActionResult CreateForm(string sentence, string word)
        {
            Word newWord = new Word(sentence, word, 0);
            return RedirectToAction("Index");
        }
    }
}