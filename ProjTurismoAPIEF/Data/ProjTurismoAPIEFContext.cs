using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjTurismoAPIEF.Models;

namespace ProjTurismoAPIEF.Data
{
    public class ProjTurismoAPIEFContext : DbContext
    {
        public ProjTurismoAPIEFContext (DbContextOptions<ProjTurismoAPIEFContext> options)
            : base(options)
        {
        }

        public DbSet<ProjTurismoAPIEF.Models.City> City { get; set; } = default!;

        public DbSet<ProjTurismoAPIEF.Models.Address>? Address { get; set; }
    }
}
