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
            }
            return View(model);
        }

        //if (answer > guess)
        //    Sorry, your answer is too low. Please try again.

        //if (answer < guess)
        //    Sorry, your answer is too high. Please try again.

        //Stretch Goals
        //tell the user if guess is too high or too low
        //tell the user if they've already guessed that number
    }
}