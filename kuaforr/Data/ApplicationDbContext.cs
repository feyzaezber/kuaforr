using kuaforr.Models;
using Microsoft.EntityFrameworkCore;

namespace kuaforr.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
        }
        public DbSet<Calisanlarimiz>Calisanlarimizs { get; set; }
        public DbSet<Hizmetlerimiz>Hizmetlerimizs { get; set; }
        public DbSet<Randevu>Randevus { get; set; }
        public DbSet<Iletisim> Iletisims { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}
