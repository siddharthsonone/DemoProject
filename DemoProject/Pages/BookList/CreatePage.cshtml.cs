
using DemoProject.Data;
using DemoProject.Models;
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

        public Book Book { get; set; }
        public void OnGet()
        {
        }
    }
}
