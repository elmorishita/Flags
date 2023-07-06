using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Flags.Models
{
    public class FlagContext : DbContext
    {

        public FlagContext(DbContextOptions<FlagContext> options) : base(options)
        { }

        public DbSet<Flag> Flags { get; set; } = null!;

     
    }
}
