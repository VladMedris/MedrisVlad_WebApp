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

namespace MedrisVlad_WebApp.Pages.Publishers
{
    public class DetailsModel : PageModel
    {
        private readonly MedrisVlad_WebApp.Data.MedrisVlad_WebAppContext _context;

        public DetailsModel(MedrisVlad_WebApp.Data.MedrisVlad_WebAppContext context)
        {
            _context = context;
        }

        public Publisher Publisher { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Publisher = await _context.Publisher.FirstOrDefaultAsync(m => m.ID == id);

            if (Publisher == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
