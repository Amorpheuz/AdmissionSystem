using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AdmissionSystem.Models;

namespace AdmissionSystem.PagesDocuments
{
    public class EditModel : PageModel
    {
        private readonly AdmissionSystem.Models.AdmissionContext _context;

        public EditModel(AdmissionSystem.Models.AdmissionContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Documents Documents { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Documents = await _context.Documents
                .Include(d => d.Student).FirstOrDefaultAsync(m => m.DocumentsID == id);

            if (Documents == null)
            {
                return NotFound();
            }
           ViewData["StudentID"] = new SelectList(_context.Student, "StudentID", "StudentID");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Documents).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DocumentsExists(Documents.DocumentsID))
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

        private bool DocumentsExists(string id)
        {
            return _context.Documents.Any(e => e.DocumentsID == id);
        }
    }
}
