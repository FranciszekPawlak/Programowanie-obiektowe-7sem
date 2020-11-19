using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PO7.Models
{
    public class po7DbContext : DbContext
    {
        public po7DbContext(DbContextOptions<po7DbContext> options) : base(options) { }
        public DbSet<Gun> Gun { get; set; }
        public DbSet<ShootingResult> ShootingResult { get; set; }
    }
}

