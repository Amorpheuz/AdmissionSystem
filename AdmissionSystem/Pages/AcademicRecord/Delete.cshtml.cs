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
    public class DeleteModel : PageModel
    {
        private readonly AdmissionSystem.Models.AdmissionContext _context;

        public DeleteModel(AdmissionSystem.Models.AdmissionContext context)
        {
            _context = context;
        }

        [BindProperty]
        public AcademicRecord AcademicRecord { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            AcademicRecord = await _context.AcademicRecord
                .Include(a => a.Student).FirstOrDefaultAsync(m => m.AcademicRecordID == id);

            if (AcademicRecord == null)
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

            AcademicRecord = await _context.AcademicRecord.FindAsync(id);

            if (AcademicRecord != null)
            {
                _context.AcademicRecord.Remove(AcademicRecord);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
