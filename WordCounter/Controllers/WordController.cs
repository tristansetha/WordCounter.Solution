using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;
using System.Collections.Generic;

namespace WordCounter.Controllers
{
    public class WordController : Controller
    {
        [HttpGet("/word")]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet("/words/new")] // test this
        public ActionResult New()
        {
            return View();
        }

        [HttpPost("/words")]
        public ActionResult Create(string word, string sentence) //test this
        {
            Word myWord = new Word(word, sentence);
            return RedirectToAction("Index");
        }

        
    }
}
