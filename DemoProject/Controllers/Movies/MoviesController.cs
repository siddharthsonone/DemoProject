using System;
using System.Collections.Generic;

using DemoProject.Models;
using Microsoft.AspNetCore.Mvc;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoProject
{
    public class MoviesController : Controller
    {
        // GET: /<controller>/
        public IActionResult RandomMovie()
        {
            var randomMovie = new Movies() { Id = '1', Name = "Shrek" };
            return View(randomMovie);
        }
        public IActionResult RandomSong()
        {
            Songs exampleSong1 = new Songs("Summer of 69", "Rock", "Bryan Adams", 180);

            Songs exampleSong2 = new Songs("Heaven", "Rock", "Bryan Adams", 150);

            Songs exampleSong3 = new Songs("Back to You", "Rock", "Bryan Adams", 210);

            Songs exampleSong4 = new Songs("Run to You", "Rock", "Bryan Adams", 210);

            List<Songs> albums = new List<Songs> { exampleSong1, exampleSong2, exampleSong3, exampleSong4 };

            Random rnd = new Random();


            return View(albums[rnd.Next(0, 3)]);
        }
    }
}
