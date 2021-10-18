﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SingleDotNetCore.Data;
using SingleDotNetCore.Models;

namespace SingleDotNetCore.Pages.AddressPages
{
    public class EditModel : PageModel
    {
        private readonly SingleDotNetCore.Data.InteractiveContext _context;

        public EditModel(SingleDotNetCore.Data.InteractiveContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Address Address { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Address = await _context.Address.FirstOrDefaultAsync(m => m.Id == id);

            if (Address == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Address).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AddressExists(Address.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool AddressExists(long id)
        {
            return _context.Address.Any(e => e.Id == id);
        }
    }
}
