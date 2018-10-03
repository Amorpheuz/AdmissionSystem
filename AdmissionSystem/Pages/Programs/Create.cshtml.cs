using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using AdmissionSystem.Models;

namespace AdmissionSystem.PagesPrograms
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
        public Programs Programs { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Programs.Add(Programs);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}