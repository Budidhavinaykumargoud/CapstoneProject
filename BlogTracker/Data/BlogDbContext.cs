using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BlogTracker.Data
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> options)
            : base(options)
        {
        }

        public DbSet<BlogTracker.Models.BlogInfo> BlogInfo { get; set; } = default!;

        public DbSet<BlogTracker.Models.EmpInfo>? EmpInfo { get; set; }
        public DbSet<BlogTracker.Models.AdminInfo> AdminInfo { get; set; }
    }
}
