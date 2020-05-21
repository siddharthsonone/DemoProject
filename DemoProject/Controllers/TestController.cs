using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoProject.Data;
using DemoProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoProject.Controllers
{
    public class TestController : Controller
    {

        private readonly ApplicationDbContext _db;
        public TestController(ApplicationDbContext db)
        {
            _db = db;

        }
        [BindProperty]
        public Test Test { get; set; }

        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {

            IEnumerable<Test> Tests = await _db.Test.ToListAsync();
            return View(Tests);
        }
        public IActionResult EditCreate(int? id)
        {
            Test = new Test();
            if (id == null)
            {
                return View(Test);
            }
            Test = _db.Test.FirstOrDefault(u => u.Id == id);
            if (Test == null)
            {
                return NotFound();
            }
            return View(Test);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditCreate()
        {
            if (ModelState.IsValid)
            {
                if (Test.Id == 0)
                {
                    //create
                    _db.Test.Add(Test);
                }
                else
                {
                    _db.Test.Update(Test);

                }


                _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            else
            {
                return View(Test);
            }

        }

    }
}
