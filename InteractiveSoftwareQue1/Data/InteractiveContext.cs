using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SingleDotNetCore.Models;

namespace SingleDotNetCore.Data
{
    public class InteractiveContext : DbContext
    {
        public InteractiveContext (DbContextOptions<InteractiveContext> options)
            : base(options)
        {
        }

        public DbSet<SingleDotNetCore.Models.Company> Company { get; set; }

        public DbSet<SingleDotNetCore.Models.Address> Address { get; set; }

        public DbSet<SingleDotNetCore.Models.Contact> Contact { get; set; }
    }
}
