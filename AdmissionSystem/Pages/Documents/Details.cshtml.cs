using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AdmissionSystem.Models;

namespace AdmissionSystem.PagesDocuments
{
    public class DetailsModel : PageModel
    {
        private readonly AdmissionSystem.Models.AdmissionContext _context;

        public DetailsModel(AdmissionSystem.Models.AdmissionContext context)
        {
            _context = context;
        }

        public Documents Documents { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Documents = await _context.Documents.FirstOrDefaultAsync(m => m.DocumentsID == id);

            if (Documents == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
