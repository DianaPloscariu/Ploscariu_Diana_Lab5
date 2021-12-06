using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ploscariu_Diana_Lab5.Models;

namespace Ploscariu_Diana_Lab5.Data
{
    public class Ploscariu_Diana_Lab5Context : DbContext
    {
        public Ploscariu_Diana_Lab5Context (DbContextOptions<Ploscariu_Diana_Lab5Context> options)
            : base(options)
        {
        }

        public DbSet<Ploscariu_Diana_Lab5.Models.Book> Book { get; set; }

        public DbSet<Ploscariu_Diana_Lab5.Models.Publisher> Publisher { get; set; }
    }
}
