using Microsoft.EntityFrameworkCore;

namespace MemeApi.Database
{

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
    }
}