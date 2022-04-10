using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorApplication.Model;

namespace RazorApplication.Pages.BookList
{
    public class IndexModel : PageModel
    {
        private ApplicationDBContext _db;
        [TempData]
        public string Message { get; set; }

        public IndexModel(ApplicationDBContext db)
        {
            _db = db;
        }

        public IEnumerable<Book> Books { get; set; }

        public async Task OnGet()
        {
            Books = await _db.Book.ToListAsync();
        }
        public async Task<IActionResult> OnPostDelete(int id)
        {
            var book = _db.Book.Find(id);
            _db.Book.Remove(book);
            await _db.SaveChangesAsync();

            Message = "Book Deleted Successfully!";

            return RedirectToPage();
        }
    }
}
