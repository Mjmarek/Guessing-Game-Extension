using GuessingGame2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GuessingGame2.Controllers
{
    public class GameController : Controller
    {
        // GET: Game
        public ActionResult Index()
        {
            Session["answer"] = new Random().Next(1, 26);
            return View();
        }

        private bool GuessWasCorrect(int guess) =>
            guess == (int)Session["answer"];

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(GameModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Win = GuessWasCorrect(model.Guess);

                ViewBag.IsLowGuess = ((int)Session["answer"] > model.Guess);                
            }
            return View(model);
        }
    }
}

//Stretch Goals: tell the user if they've already guessed that number

//ViewBag.IsLowGuess = ((int) Session["answer"] > model.Guess);
//this is the same as the lines below (because condition is already a boolian)

//if ((int) Session["answer"] > model.Guess)
//{
//    ViewBag.IsLowGuess = true;
//}
//else
//{
//    ViewBag.IsLowGuess = false;
//}