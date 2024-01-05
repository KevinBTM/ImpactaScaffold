using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SisCad.Models;

namespace SisCad.Data
{
    public class SisCadContext : DbContext
    {
        public SisCadContext (DbContextOptions<SisCadContext> options)
            : base(options)
        {
        }

        public DbSet<SisCad.Models.Cliente> Cliente { get; set; } = default!;

        public DbSet<SisCad.Models.Produto>? Produto { get; set; }
    }
}
