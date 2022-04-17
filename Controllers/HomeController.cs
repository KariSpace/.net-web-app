using DictionaryWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DictionaryWebApp.Data;

namespace DictionaryWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var rnd = new Random();
            var WordsList = _context.Word.Select(x => x.WordText).ToList();
            var idx = 0;
            if (WordsList.Count > 0)
            { 
                idx = rnd.Next(0, WordsList.Count - 1);
                var WordsDict = WordsList.ToDictionary(x => WordsList.IndexOf(x));
                ViewBag.RandomWord = "Word of the day: " + WordsDict[idx];
                var WordsTranslationList = _context.Word.Select(x => x.WordTranslate).ToList();
                var WordsTranslationDict = WordsTranslationList.ToDictionary(x => WordsTranslationList.IndexOf(x));
                ViewBag.RandomWordTranslation = "Translation: " + WordsTranslationDict[idx];
            }
            ViewBag.RandomWord = "";
            ViewBag.RandomWordTranslation = "";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
