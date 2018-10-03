using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AdmissionSystem.Models;

namespace AdmissionSystem.Models
{
    public class AdmissionContext : DbContext
    {
        public AdmissionContext (DbContextOptions<AdmissionContext> options)
            : base(options)
        {
        }

        public DbSet<AdmissionSystem.Models.Student> Student { get; set; }

        public DbSet<AdmissionSystem.Models.Documents> Documents { get; set; }

        public DbSet<AdmissionSystem.Models.ApplicationList> ApplicationList { get; set; }

        public DbSet<AdmissionSystem.Models.AcademicRecord> AcademicRecord { get; set; }

        public DbSet<AdmissionSystem.Models.AcademicYear> AcademicYear { get; set; }

        public DbSet<AdmissionSystem.Models.Fees> Fees { get; set; }

        public DbSet<AdmissionSystem.Models.Programs> Programs { get; set; }
    }
}
