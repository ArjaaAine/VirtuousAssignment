#nullable disable
using Microsoft.EntityFrameworkCore;
using Virtuous.Web.Models;

namespace Virtuous.Data
{
    public class VirtuousContext : DbContext
    {
        public VirtuousContext (DbContextOptions<VirtuousContext> options)
            : base(options)
        {
        }

        public DbSet<Donation> Donation { get; set; }
    }
}
