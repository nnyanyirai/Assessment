using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SingleDotNetCore.Data;
using SingleDotNetCore.Models;

namespace SingleDotNetCore.Pages.CompanyPages
{
    public class IndexModel : PageModel
    {
        private readonly SingleDotNetCore.Data.InteractiveContext _context;

        public IndexModel(SingleDotNetCore.Data.InteractiveContext context)
        {
            _context = context;
        }

        public IList<Company> Company { get;set; }

        public async Task OnGetAsync()
        {
            Company = await _context.Company.ToListAsync();
        }
    }
}
