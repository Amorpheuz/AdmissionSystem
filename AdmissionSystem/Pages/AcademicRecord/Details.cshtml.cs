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
    public class DetailsModel : PageModel
    {
        private readonly AdmissionSystem.Models.AdmissionContext _context;

        public DetailsModel(AdmissionSystem.Models.AdmissionContext context)
        {
            _context = context;
        }

        public AcademicRecord AcademicRecord { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            AcademicRecord = await _context.AcademicRecord.FirstOrDefaultAsync(m => m.AcademicRecordID == id);

            if (AcademicRecord == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
