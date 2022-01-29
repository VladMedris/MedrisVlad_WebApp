﻿#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MedrisVlad_WebApp.Data;
using MedrisVlad_WebApp.Models;

namespace MedrisVlad_WebApp.Pages.Libraries
{
    public class IndexModel : PageModel
    {
        private readonly MedrisVlad_WebApp.Data.MedrisVlad_WebAppContext _context;

        public IndexModel(MedrisVlad_WebApp.Data.MedrisVlad_WebAppContext context)
        {
            _context = context;
        }

        public IList<Library> Library { get;set; }

        public async Task OnGetAsync()
        {
            Library = await _context.Library.ToListAsync();
        }
    }
}
