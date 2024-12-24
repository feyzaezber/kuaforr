using Microsoft.EntityFrameworkCore;

namespace kuaforr.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
        }
    }
}
