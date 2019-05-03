using Microsoft.AspNetCore.Mvc;
using WordCounter;
using System.Collections.Generic;

namespace WordCounter.Controllers
{
    public class WordController : Controller
    {
        [HttpGet("/Index")]
        public ActionResult Index(Word newWord)
        {
           
            return View(newWord);
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
            return View("Index", newWord);
        }
        [HttpPost("/Previous/delete")]
        public ActionResult DeleteAll()
        {
            Word.ClearAll();
            return View();
        }
        [HttpGet("/Previous/all")]
        public ActionResult Previous()
        {
            List<Word> allItems = Word.GetAll();
            return View(allItems);
        }

        [HttpGet("/Show/{id}")]
        public ActionResult Show(int id)
        {
            Word word = Word.Find(id);
            return View(word);
        }
        
    }
}