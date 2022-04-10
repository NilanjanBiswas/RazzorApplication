using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorApplication.Model;

namespace RazorApplication.Pages.BookList
{
    public class CreateModel : PageModel
    {
        private ApplicationDBContext _db;

        [TempData]
        public string Message { get; set; }


        public CreateModel(ApplicationDBContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Book Book { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _db.Book.Add(Book);
            await _db.SaveChangesAsync();
            Message = "New Book Added successfully!";
            return RedirectToPage("Index");
        }
    }
}
