using CommanderGQLApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CommanderGQLApi.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Platform> Platforms { get; set; }
    }
}
