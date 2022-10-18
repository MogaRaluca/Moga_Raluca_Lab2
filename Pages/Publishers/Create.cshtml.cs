﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Moga_Raluca_Lab2.Data;
using Moga_Raluca_Lab2.Models;

namespace Moga_Raluca_Lab2.Pages.Publishers
{
    public class CreateModel : PageModel
    {
        private readonly Moga_Raluca_Lab2.Data.Moga_Raluca_Lab2Context _context;

        public CreateModel(Moga_Raluca_Lab2.Data.Moga_Raluca_Lab2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Publisher Publisher { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Publisher.Add(Publisher);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
