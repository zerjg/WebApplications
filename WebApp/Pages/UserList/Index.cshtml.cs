﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp.Models;

namespace WebApp.Pages.Users
{
    public class IndexModel : PageModel
    {
        public AppDbContext db = new AppDbContext();

        public List<User> Users { get; set; }

        public void OnGet()
        {
            Users = db.Users.ToList();
        }
    }
}