using Lab22.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab21.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Summary(string firstName, string lastName, string email, string phone, string password)
        {
            
            

            User user = new User(ToTitle(firstName),ToTitle(lastName),email,phone,password);
            return View(user);
        }

        public string ToTitle(string word)
        {
            string newWord = "";

            for(int i = 0; i < word.Length ;i++)
            {
                if (i == 0)
                {
                    newWord += word[i].ToString().ToUpper();
                }
                else
                {
                    newWord += word[i].ToString().ToLower();
                }
            }
            return newWord;
        }
        




    }
}