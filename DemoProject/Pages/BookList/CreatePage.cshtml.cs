
using System.Threading.Tasks;
using DemoProject.Data;
using DemoProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DemoProject.Pages.BookList
{
    public class CreatePageModel : PageModel
    {

        private readonly ApplicationDbContext _db;
        public CreatePageModel(ApplicationDbContext db)
        {
            _db = db;
        }

        //following is done to bind the Book object from the html 
        [BindProperty]
        public Book Book { get; set; }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                await _db.AddAsync(Book);
                await _db.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
    }
}
