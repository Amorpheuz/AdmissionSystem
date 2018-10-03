using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using AdmissionSystem.Models;

namespace AdmissionSystem.PagesFees
{
    public class CreateModel : PageModel
    {
        private readonly AdmissionSystem.Models.AdmissionContext _context;

        public CreateModel(AdmissionSystem.Models.AdmissionContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Fees Fees { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Fees.Add(Fees);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}