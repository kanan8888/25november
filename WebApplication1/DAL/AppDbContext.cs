using Microsoft.EntityFrameworkCore;

namespace WebApplication1.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
