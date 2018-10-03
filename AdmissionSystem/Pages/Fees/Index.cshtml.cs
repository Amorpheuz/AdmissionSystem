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
    public class IndexModel : PageModel
    {
        private readonly AdmissionSystem.Models.AdmissionContext _context;

        public IndexModel(AdmissionSystem.Models.AdmissionContext context)
        {
            _context = context;
        }

        public IList<Fees> Fees { get;set; }

        public async Task OnGetAsync()
        {
            Fees = await _context.Fees.ToListAsync();
        }
    }
}
