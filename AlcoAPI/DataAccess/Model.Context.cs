namespace DataAccess
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class postgresEntities : DbContext
    {
        public postgresEntities()
            : base("name=postgresEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<category> categories { get; set; }
        public DbSet<client> clients { get; set; }
        public DbSet<guaro> guaroes { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<shopping> shoppings { get; set; }
        public DbSet<type> types { get; set; }
    }
}
