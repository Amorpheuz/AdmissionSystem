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
    public class DetailsModel : PageModel
    {
        private readonly AdmissionSystem.Models.AdmissionContext _context;

        public DetailsModel(AdmissionSystem.Models.AdmissionContext context)
        {
            _context = context;
        }

        public Programs Programs { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Programs = await _context.Programs.FirstOrDefaultAsync(m => m.ProgramsID == id);

            if (Programs == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
