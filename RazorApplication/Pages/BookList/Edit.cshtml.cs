using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorApplication.Model;
namespace RazorApplication.Pages.BookList
{
    public class EditModel : PageModel
    {
        private ApplicationDBContext _db;

        public EditModel(ApplicationDBContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Book Book { get; set; }

        [TempData]
        public string Message { get; set; }

        public void OnGet(int id)
        {
            Book = _db.Book.Find(id);
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var bookInDb = _db.Book.Find(Book.id);
                bookInDb.ISBN = Book.ISBN;
                bookInDb.Name = Book.Name;
                bookInDb.Author = Book.Author;
                bookInDb.Avaibility = Book.Avaibility;
                bookInDb.Price = Book.Price;

                await _db.SaveChangesAsync();
                Message = "Book updated successfuly!";

                return RedirectToPage("Index");
            }
            return RedirectToPage();
        }
    }
}
