using buzz.Models;
using Microsoft.EntityFrameworkCore;

namespace buzz.NewFolder1
{
    public class AppDbContext : DbContext
    {
        public AppDbContext ( DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<recentwork> recentworks { get; set; }
    }
}
