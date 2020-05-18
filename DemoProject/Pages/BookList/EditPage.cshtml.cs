
using System.Threading.Tasks;
using DemoProject.Data;
using DemoProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DemoProject.Pages.BookList
{
    public class EditPageModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public EditPageModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Book Book { get; set; }

        public async Task OnGet(int id)
        {
            Book = await _db.Book.FindAsync(id);
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var retrivedBook = await _db.Book.FindAsync(Book.Key);
                retrivedBook.Name = Book.Name;
                retrivedBook.Author = Book.Author;
                retrivedBook.ISBN = Book.ISBN;

                await _db.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            else
            {
                return RedirectToPage();
            }
        }
    }
}
