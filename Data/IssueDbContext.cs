using Microsoft.EntityFrameworkCore;
using trackingapi.models;

namespace trackingapi.Data
{
    public class IssueDbContext : DbContext
    {
        public IssueDbContext(DbContextOptions<IssueDbContext> options)
            : base(options)
        {
        }
        public DbSet<Issue> Issues { get; set; }
    }
}
