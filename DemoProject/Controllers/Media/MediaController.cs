using System;
using System.Collections.Generic;
using System.IO;
using DemoProject.Models;
using Microsoft.AspNetCore.Mvc;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoProject
{
    public class MediaController : Controller
    {


        //NOT A CONTROLLER used to return JSON strings!
        private static string HelperMethodRandomString(int maxRange)
        {
            var randomWords = new List<String> { "random", "troubled", "yell", "month", "society", "milk", "solid", "grandmother", "vacuous", "petite", "cellar", "tawdry", "refuse", };
            Random rnd = new Random();
            return randomWords[rnd.Next(0, maxRange)];
        }

        // /Media/RandomMovie
        public IActionResult RandomMovie()
        {
            Movies exampleMovie1 = new Movies("Kill Bill", "Action", "Quentin Tarantino", 180);

            Movies exampleMovie2 = new Movies("Hateful Eight", "Action", "Quentin Tarantino", 180);

            Movies exampleMovie3 = new Movies("Kill Bill Vol 2", "Action", "Quentin Tarantino", 180);

            Movies exampleMovie4 = new Movies("DeathProof", "Action", "Quentin Tarantino", 180);

            List<Movies> albums = new List<Movies> { exampleMovie1, exampleMovie2, exampleMovie3, exampleMovie4 };

            Random rnd = new Random();

            //can use ViewResult
            return View(albums[rnd.Next(0, 3)]);


        }
        // /Media/RandomSong
        public IActionResult RandomSong()
        {
            Songs exampleSong1 = new Songs("Summer of 69", "Rock", "Bryan Adams", 180);

            Songs exampleSong2 = new Songs("Heaven", "Rock", "Bryan Adams", 150);

            Songs exampleSong3 = new Songs("Back to You", "Rock", "Bryan Adams", 210);

            Songs exampleSong4 = new Songs("Run to You", "Rock", "Bryan Adams", 210);

            List<Songs> albums = new List<Songs> { exampleSong1, exampleSong2, exampleSong3, exampleSong4 };

            Random rnd = new Random();

            //can use ViewResult
            return View(albums[rnd.Next(0, 3)]);
        }

        // /Media/RandomText
        //used to return strings!
        public ContentResult RandomText()
        {
            string randomWord = HelperMethodRandomString(11);
            return Content(randomWord);
        }

        // /Media/RandomJSON
        //used to return JSON strings!
        public JsonResult RandomJSON()
        {
            string randomWord = HelperMethodRandomString(11);
            var json_data = new { word = randomWord };
            return Json(json_data);
        }
        // /Media/RandomFile
        //used to return a File!
        public FileResult RandomFile()
        {
            //fileName
            string name = "RandomFile.txt";
            string randomWord = HelperMethodRandomString(11);

            FileInfo info = new FileInfo(name);
            if (!info.Exists)
            {
                using (StreamWriter writer = info.CreateText())
                {
                    writer.WriteLine("Hello, I am thinking about {0}", randomWord);

                }
            }

            return File(info.OpenRead(), "text/plain");
        }
        // /Media/RedirectUser
        //used to redirect 302!
        public RedirectToActionResult RedirectUser()
        {
            //optional for query parameters
            //new {page = 1, sortBy = "name"} 
            return RedirectToAction("Index","Home");
        }
        // /Media/edit?id=473489
        //parse query params
        public ActionResult Edit(int id)
        {
            return Content("id=" +id);
        }


    }
}

