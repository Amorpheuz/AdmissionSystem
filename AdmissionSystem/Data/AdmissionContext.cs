using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AdmissionSystem.Models
{
    public class AdmissionContext : DbContext
    {
        public AdmissionContext (DbContextOptions<AdmissionContext> options)
            : base(options)
        {
        }

        public DbSet<AdmissionSystem.Models.Student> Student { get; set; }
    }
}
