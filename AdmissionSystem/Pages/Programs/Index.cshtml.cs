using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AdmissionSystem.Models;

namespace AdmissionSystem.PagesPrograms
{
    public class IndexModel : PageModel
    {
        private readonly AdmissionSystem.Models.AdmissionContext _context;

        public IndexModel(AdmissionSystem.Models.AdmissionContext context)
        {
            _context = context;
        }

        public IList<Programs> Programs { get;set; }

        public async Task OnGetAsync()
        {
            Programs = await _context.Programs.ToListAsync();
        }
    }
}
