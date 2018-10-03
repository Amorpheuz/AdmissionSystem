using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AdmissionSystem.Models;

namespace AdmissionSystem.PagesFees
{
    public class DeleteModel : PageModel
    {
        private readonly AdmissionSystem.Models.AdmissionContext _context;

        public DeleteModel(AdmissionSystem.Models.AdmissionContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Fees Fees { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Fees = await _context.Fees.FirstOrDefaultAsync(m => m.FeesID == id);

            if (Fees == null)
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

            Fees = await _context.Fees.FindAsync(id);

            if (Fees != null)
            {
                _context.Fees.Remove(Fees);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
