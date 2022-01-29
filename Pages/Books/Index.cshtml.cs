#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MedrisVlad_WebApp.Data;
using MedrisVlad_WebApp.Models;

namespace MedrisVlad_WebApp.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly MedrisVlad_WebApp.Data.MedrisVlad_WebAppContext _context;

        public IndexModel(MedrisVlad_WebApp.Data.MedrisVlad_WebAppContext context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; }
            
        public async Task OnGetAsync()
        {
            Book = await _context.Book.Include(b => b.Publisher).ToListAsync();
        }
    }
}
