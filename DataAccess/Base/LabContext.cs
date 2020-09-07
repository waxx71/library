using library.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace library.DataAccess.Base
{
    public class LabContext : DbContext
    {
        public LabContext(DbContextOptions<LabContext> options)
            : base(options)
        { }

        public DbSet<Reader> Reader { get; set; }
        public DbSet<Borrows> Borrows { get; set; }
        public DbSet<Returns> Returns { get; set; }
        public DbSet<Violation> Violation { get; set; }
        public DbSet<Timeslot> Timeslot { get; set; }
        public DbSet<Book> Book { get; set; }
    }
}
