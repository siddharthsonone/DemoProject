
using System;
using System.Linq;
using DemoProject.Data;
using DemoProject.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoProject.Controllers
{
    [Route("api/Book")]
    [ApiController]
    public class BookController : Controller
    {

        private readonly ApplicationDbContext _db;

        public BookController(ApplicationDbContext db)
        {
            _db = db;
        }

        public Book Book { get; set; }
        // GET: /<controller>/


        [HttpGet]
        public IActionResult Index()
        {
            var data = _db.Book.ToList();
            return Json(new { data = data });
        }




    }
}
