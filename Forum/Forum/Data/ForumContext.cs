using Forum.Models;
using Microsoft.EntityFrameworkCore;

namespace Forum.Data
{
    public class ForumContext: DbContext
    {
        public ForumContext(DbContextOptions<ForumContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
    }
}
