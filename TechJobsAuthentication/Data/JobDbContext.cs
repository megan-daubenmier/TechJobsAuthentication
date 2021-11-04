using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TechJobsAuthentication.Models;

namespace TechJobsAuthentication.Data
{
    public class JobDbContext : IdentityDbContext
    {
        public DbSet<Job> Jobs { get; set; }

        public JobDbContext(DbContextOptions<JobDbContext> options) : base(options)
        {
        }
    }
}
