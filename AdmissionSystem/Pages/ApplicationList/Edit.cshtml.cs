using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AdmissionSystem.Models;

namespace AdmissionSystem.PagesApplicationList
{
    public class EditModel : PageModel
    {
        private readonly AdmissionSystem.Models.AdmissionContext _context;

        public EditModel(AdmissionSystem.Models.AdmissionContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ApplicationList ApplicationList { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ApplicationList = await _context.ApplicationList
                .Include(a => a.AcademicYear)
                .Include(a => a.Student).FirstOrDefaultAsync(m => m.ApplicationListID == id);

            if (ApplicationList == null)
            {
                return NotFound();
            }
           ViewData["AcademicYearID"] = new SelectList(_context.AcademicYear, "AcademicYearID", "AcademicYearID");
           ViewData["StudentID"] = new SelectList(_context.Student, "StudentID", "StudentID");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(ApplicationList).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ApplicationListExists(ApplicationList.ApplicationListID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ApplicationListExists(int id)
        {
            return _context.ApplicationList.Any(e => e.ApplicationListID == id);
        }
    }
}
