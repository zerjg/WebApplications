using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp.Models;

namespace WebApp.Pages.UserList
{
    public class CreateModel : PageModel
    {
        public AppDbContext db = new AppDbContext();

        [BindProperty]
        public User User { get; set; }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            db.Users.Add(User);
            db.SaveChanges();

            return RedirectToPage("Index");
        }
    }
}