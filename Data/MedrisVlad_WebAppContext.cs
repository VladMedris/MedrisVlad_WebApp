#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MedrisVlad_WebApp.Models;

namespace MedrisVlad_WebApp.Data
{
    public class MedrisVlad_WebAppContext : DbContext
    {
        public MedrisVlad_WebAppContext (DbContextOptions<MedrisVlad_WebAppContext> options)
            : base(options)
        {
        }

        public DbSet<MedrisVlad_WebApp.Models.Book> Book { get; set; }

        public DbSet<MedrisVlad_WebApp.Models.Publisher> Publisher { get; set; }

        public DbSet<MedrisVlad_WebApp.Models.BookCategory> BookCategory { get; set; }

        public DbSet<MedrisVlad_WebApp.Models.Category> Category { get; set; }
    }
}
