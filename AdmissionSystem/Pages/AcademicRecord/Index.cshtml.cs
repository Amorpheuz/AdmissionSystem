using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AdmissionSystem.Models;

namespace AdmissionSystem.PagesAcademicRecord
{
    public class IndexModel : PageModel
    {
        private readonly AdmissionSystem.Models.AdmissionContext _context;

        public IndexModel(AdmissionSystem.Models.AdmissionContext context)
        {
            _context = context;
        }

        public IList<AcademicRecord> AcademicRecord { get;set; }

        public async Task OnGetAsync()
        {
            AcademicRecord = await _context.AcademicRecord
                .Include(a => a.Student).ToListAsync();
        }
    }
}
