using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace WebApp.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public string Text { get; set; }

        public void OnGet()
        {
            if (Text == null)
            {
                Text = "Привет, друг!!!";
            }
        }

        public void OnPost()
        {
            
        }
    }
}
