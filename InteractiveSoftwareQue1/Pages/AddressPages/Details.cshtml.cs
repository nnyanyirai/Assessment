using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SingleDotNetCore.Data;
using SingleDotNetCore.Models;

namespace SingleDotNetCore.Pages.AddressPages
{
    public class DetailsModel : PageModel
    {
        private readonly SingleDotNetCore.Data.InteractiveContext _context;

        public DetailsModel(SingleDotNetCore.Data.InteractiveContext context)
        {
            _context = context;
        }

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
    }
}
