using AlcoAPI.Models.Mapping;
using Microsoft.EntityFrameworkCore;

namespace AlcoAPI.Models
{
    public partial class Context : DbContext
    {
        public Context() { }

        public Context(DbContextOptions<Context> options) : base(options) { }

        public DbSet<Entities.Client> Client { get; set; }
        public DbSet<Entities.Invoice> Invoice { get; set; }
        public DbSet<Entities.Guaro> Guaro { get; set; }
        public DbSet<Entities.Shopping> Shopping { get; set; }
        public DbSet<Entities.Category> Category { get; set; }
        public DbSet<Entities.Type> Type { get; set; }
        public DbSet<Entities.CategoryType> CategoryType { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClientMap());
            modelBuilder.ApplyConfiguration(new InvoiceMap());
            modelBuilder.ApplyConfiguration(new GuaroMap());
            modelBuilder.ApplyConfiguration(new ShoppingMap());
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new TypeMap());
            modelBuilder.ApplyConfiguration(new CategoryTypeMap());

        }
    }
}
