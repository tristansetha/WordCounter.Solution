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
            List<Word> allWords = Word.GetAll();
            return View(allWords);
        }

        [HttpGet("/word/new")] // test this
        public ActionResult New()
        {
            return View();
        }

        [HttpPost("/word")]
        public ActionResult Create(string wordInput, string sentenceInput) //test this
        {         
            Word myWord = new Word(wordInput, sentenceInput);
            int wordCount = myWord.CountWords(wordInput, sentenceInput);
            myWord.SetWordCount(wordCount); 
            return RedirectToAction("Index");
        }
    }
}
