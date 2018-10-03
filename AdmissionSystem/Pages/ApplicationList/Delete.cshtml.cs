using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AdmissionSystem.Models;

namespace AdmissionSystem.PagesApplicationList
{
    public class DeleteModel : PageModel
    {
        private readonly AdmissionSystem.Models.AdmissionContext _context;

        public DeleteModel(AdmissionSystem.Models.AdmissionContext context)
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

            ApplicationList = await _context.ApplicationList.FirstOrDefaultAsync(m => m.ApplicationListID == id);

            if (ApplicationList == null)
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

            ApplicationList = await _context.ApplicationList.FindAsync(id);

            if (ApplicationList != null)
            {
                _context.ApplicationList.Remove(ApplicationList);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
