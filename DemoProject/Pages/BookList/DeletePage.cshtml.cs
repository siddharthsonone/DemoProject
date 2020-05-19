using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoProject.Data;
using DemoProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DemoProject.Pages.BookList
{
    public class DeletePageModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public DeletePageModel(ApplicationDbContext db)
        {
            _db = db;
        }
        [BindProperty]
        public Book Book { get; set; }

        public async Task OnGet(int id)
        {
            Book = await _db.Book.FindAsync(id);
        }
        public async Task<IActionResult> OnPost(int id)
        {


            var book = await _db.Book.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }
            _db.Book.Remove(book);
            await _db.SaveChangesAsync();

            return RedirectToPage("Index");
        }


    }
}
