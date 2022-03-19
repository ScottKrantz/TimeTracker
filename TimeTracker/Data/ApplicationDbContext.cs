using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TimeTracker.Models;

namespace TimeTracker.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<TimeTracker.Models.Company> Company { get; set; }
        public DbSet<TimeTracker.Models.Project> Project { get; set; }
        public DbSet<TimeTracker.Models.ProjectLog> ProjectLog { get; set; }
        public DbSet<TimeTracker.Models.ProjectPriority> ProjectPriority { get; set; }
        public DbSet<TimeTracker.Models.User> User { get; set; }
    }
}
