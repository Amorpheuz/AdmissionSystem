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
    public class IndexModel : PageModel
    {
        private readonly AdmissionSystem.Models.AdmissionContext _context;

        public IndexModel(AdmissionSystem.Models.AdmissionContext context)
        {
            _context = context;
        }

        public IList<Documents> Documents { get;set; }

        public async Task OnGetAsync()
        {
            Documents = await _context.Documents.ToListAsync();
        }
    }
}
