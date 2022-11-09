using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Moga_Raluca_Lab2.Models;

namespace Moga_Raluca_Lab2.Data
{
    public class Moga_Raluca_Lab2Context : DbContext
    {
        public Moga_Raluca_Lab2Context (DbContextOptions<Moga_Raluca_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Moga_Raluca_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Moga_Raluca_Lab2.Models.Publisher> Publisher { get; set; }

        public DbSet<Moga_Raluca_Lab2.Models.Author> Author { get; set; }

        public DbSet<Moga_Raluca_Lab2.Models.Category> Category { get; set; }

        public DbSet<Moga_Raluca_Lab2.Models.Member> Member { get; set; }

        public DbSet<Moga_Raluca_Lab2.Models.Borrowing> Borrowing { get; set; }
    }
}
