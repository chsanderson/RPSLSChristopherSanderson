using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Session;
//Christopher Sanderson

namespace RPSLSChristopherSanderson.Controllers
{
    public class RPSLSController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //this checks whether the user has won drawn or lost when selecting rock
        [HttpGet]
        public IActionResult Rock()
        {
            //this creates a string variable called Selection with a value of Rock
            string Selection = "Rock";
            string[] arrayString = { "Rock", "Paper", "Scissors", "Lizard", "Spock" };
            Random random = new Random();
            int randomGame = random.Next(arrayString.Length);
            string randomString = arrayString[randomGame];
            //this checks if both the random move and the string variable selection both equal Rock
            if (Selection == randomString)
            {
                //This stores a message telling the user the game has been drawn
                TempData["Message"] = "Draw";
                //this calls on the function to be able to add 1 to the Session variable Drawn which stores the value of how many draws a user has had
                drawn();
            }
            //this checks if the random move matches any of the others(Spock, Scissors, Lizard, Paper) and stores a message relating to what it means to rock as well as calling a function 
            //which adds 1 to the score such as calling the lost function if the user has lost and the won function if the user has won. 
            if (randomString == "Spock")
            {
                TempData["Message"] = "Spock Vapourises Rock. You Lose!";
                lost();
            }
            if (randomString == "Scissors")
            {
                TempData["Message"] = "Rock Crushes Scissors. You Win!";
                won();
            }
            if (randomString == "Lizard")
            {
                TempData["Message"] = "Rock Crushes Lizard. You Win!";
                won();
            }
            //this checks if the 
            if (randomString == "Paper")
            {
                TempData["Message"] = "Paper Covers Rock. You Lose!";
                lost();
            }
            return RedirectToAction("Index", "Home");
        }

        //this checks whether the user has won drawn or lost when selecting Paper
        [HttpGet]
        public IActionResult Paper()
        {
            //this creates a string variable called Selection with a value of Paper
            string Selection = "Paper";
            string[] arrayString = { "Rock", "Paper", "Scissors", "Lizard", "Spock" };
            Random random = new Random();
            int randomGame = random.Next(arrayString.Length);
            string randomString = arrayString[randomGame];
            //this checks if both the random move and the string variable selection both equal Paper
            if (Selection == randomString)
            {
                //This stores a message telling the user the game has been drawn
                TempData["Message"] = "Draw";
                //this calls on the function to be able to add 1 to the Session variable Drawn which stores the value of how many draws a user has had
                drawn();
            }
            //this checks if the random move matches any of the others(Spock, Scissors, Lizard, Paper) and stores a message relating to what it means to rock as well as calling a function 
            //which adds 1 to the score such as calling the lost function if the user has lost and the won function if the user has won. 
            if (randomString == "Spock")
            {
                TempData["Message"] = "Paper Disproves Spock. You Win!";
                won();
            }
            if (randomString == "Scissors")
            {
                TempData["Message"] = "Scissors Cut Paper. You Lose!";
                lost();
            }
            if (randomString == "Lizard")
            {
                TempData["Message"] = "Lizard Eats Paper. You Lose!";
                lost();
            }
            if (randomString == "Rock")
            {
                TempData["Message"] = "Paper Covers Rock. You Win!";
                won();
            }
            return RedirectToAction("Index", "Home");
        }

        //this checks whether the user has won drawn or lost when selecting Scissors
        [HttpGet]
        public IActionResult Scissors()
        {
            //this creates a string variable called Selection with a value of Scissors
            string Selection = "Scissors";
            string[] arrayString = { "Rock", "Paper", "Scissors", "Lizard", "Spock" };
            Random random = new Random();
            int randomGame = random.Next(arrayString.Length);
            string randomString = arrayString[randomGame];
            //this checks if both the random move and the string variable selection both equal Scissors
            if (Selection == randomString)
            {
                //This stores a message telling the user the game has been drawn
                TempData["Message"] = "Draw";
                //this calls on the function to be able to add 1 to the Session variable Drawn which stores the value of how many draws a user has had
                drawn();
            }
            //this checks if the random move matches any of the others(Spock, Rock, Lizard, Paper) and stores a message relating to what it means to rock as well as calling a function 
            //which adds 1 to the score such as calling the lost function if the user has lost and the won function if the user has won. 
            if (randomString == "Spock")
            {
                TempData["Message"] = "Spock Smashes Scissors. You Lose!";
                lost();
            }
            if (randomString == "Rock")
            {
                TempData["Message"] = "Rock Crushes Scissors. You Lose!";
                lost();
            }
            if (randomString == "Lizard")
            {
                TempData["Message"] = "Scissors Decapitates Lizard. You Win!";
                won();
            }
            if (randomString == "Paper")
            {
                TempData["Message"] = "Scissors Cuts Paper. You Win!";
                won();
            }
            return RedirectToAction("Index", "Home");
        }

        //this checks whether the user has won drawn or lost when selecting Lizard
        [HttpGet]
        public IActionResult Lizard()
        {
            //this creates a string variable called Selection with a value of Lizard
            string Selection = "Lizard";
            string[] arrayString = { "Rock", "Paper", "Scissors", "Lizard", "Spock" };
            Random random = new Random();
            int randomGame = random.Next(arrayString.Length);
            string randomString = arrayString[randomGame];
            //this checks if both the random move and the string variable selection both equal Lizard
            if (Selection == randomString)
            {
                //This stores a message telling the user the game has been drawn
                TempData["Message"] = "Draw";
                //this calls on the function to be able to add 1 to the Session variable Drawn which stores the value of how many draws a user has had
                drawn();
            }

            //this checks if the random move matches any of the others(Spock, Scissors, Rock, Paper) and stores a message relating to what it means to rock as well as calling a function 
            //which adds 1 to the score such as calling the lost function if the user has lost and the won function if the user has won. 
            if (randomString == "Spock")
            {
                TempData["Message"] = "Lizard Poisons Spock. You Win!";
                won();
            }
            if (randomString == "Scissors")
            {
                TempData["Message"] = "Scissors Decapitates Lizard. You Lose!";
                lost();
            }
            if (randomString == "Rock")
            {
                TempData["Message"] = "Rock Crushes Lizard. You Lose!";
                lost();
            }
            if (randomString == "Paper")
            {
                TempData["Message"] = "Lizard eats Paper. You Win!";
                won();
            }
            return RedirectToAction("Index", "Home");
        }

        //this checks whether the user has won drawn or lost when selecting Spock
        [HttpGet]
        public IActionResult Spock()
        {
            //this creates a string variable called Selection with a value of Spock
            string Selection = "Spock";
            string[] arrayString = { "Rock", "Paper", "Scissors", "Lizard", "Spock" };
            Random random = new Random();
            int randomGame = random.Next(arrayString.Length);
            string randomString = arrayString[randomGame];
            //this checks if both the random move and the string variable selection both equal Spock
            if (Selection == randomString)
            {
                //This stores a message telling the user the game has been drawn
                TempData["Message"] = "Draw";
                //this calls on the function to be able to add 1 to the Session variable Drawn which stores the value of how many draws a user has had
                drawn();
            }

            //this checks if the random move matches any of the others(Rock, Scissors, Lizard, Paper) and stores a message relating to what it means to rock as well as calling a function 
            //which adds 1 to the score such as calling the lost function if the user has lost and the won function if the user has won. 
            if (randomString == "Rock")
            {
                TempData["Message"] = "Spock Vapourises Rock. You Win!";
                won();
            }
            if (randomString == "Scissors")
            {
                TempData["Message"] = "Spock Smashes Scissors. You Win!";
                won();
            }
            if (randomString == "Lizard")
            {
                TempData["Message"] = "Lizard Poisons Spock. You Lose!";
                lost();
            }
            if (randomString == "Paper")
            {
                TempData["Message"] = "Paper Disproves Spock. You Lose!";
                lost();
            }
            return RedirectToAction("Index", "Home");
        }

        //these functions add a value of 1 to allow the user to keep track of their score using session variables
        public void won()
        {
            if (HttpContext.Session.GetString("Won") == null)
            {
                HttpContext.Session.SetString("Won", 0.ToString());
            }
            else
            {
                int won = int.Parse(HttpContext.Session.GetString("Won"));
                HttpContext.Session.SetString("Won",(won + 1).ToString());
            }
        }

        public void drawn()
        {
            if (HttpContext.Session.GetString("Drawn") == null)
            {
                TempData["Drawn"] = 0;
            }
            else
            {
                int drawn = int.Parse(HttpContext.Session.GetString("Drawn"));
                HttpContext.Session.SetString("Drawn",( drawn + 1).ToString());
            }
        }

        public void lost()
        {
            if (HttpContext.Session.GetString("Lost") == null)
            {
                HttpContext.Session.SetString("Lost", 0.ToString());
            }
            else
            {
                int lost = int.Parse(HttpContext.Session.GetString("Lost"));
                HttpContext.Session.SetString("Lost",(lost + 1).ToString());
            }
        }
    }
}