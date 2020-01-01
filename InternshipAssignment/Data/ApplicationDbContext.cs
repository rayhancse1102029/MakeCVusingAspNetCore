using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using InternshipAssignment.Models;

namespace InternshipAssignment.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public DbSet<InternshipAssignment.Models.Department> Department { get; set; }

        public DbSet<InternshipAssignment.Models.GenderModel> GenderModel { get; set; }

        public DbSet<InternshipAssignment.Models.Language> Language { get; set; }

        public DbSet<InternshipAssignment.Models.MaritalStatus> MaritalStatus { get; set; }

        public DbSet<InternshipAssignment.Models.Religion> Religion { get; set; }

        public DbSet<InternshipAssignment.Models.CvModel> CvModel { get; set; }
    }
}
