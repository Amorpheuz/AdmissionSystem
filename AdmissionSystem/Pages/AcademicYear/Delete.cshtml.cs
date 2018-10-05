using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AdmissionSystem.Models;

namespace AdmissionSystem.PagesAcademicYear
{
    public class DeleteModel : PageModel
    {
        private readonly AdmissionSystem.Models.AdmissionContext _context;

        public DeleteModel(AdmissionSystem.Models.AdmissionContext context)
        {
            _context = context;
        }

        [BindProperty]
        public AcademicYear AcademicYear { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            AcademicYear = await _context.AcademicYear
                .Include(a => a.Programs).FirstOrDefaultAsync(m => m.AcademicYearID == id);

            if (AcademicYear == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            AcademicYear = await _context.AcademicYear.FindAsync(id);

            if (AcademicYear != null)
            {
                _context.AcademicYear.Remove(AcademicYear);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
