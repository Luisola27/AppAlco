using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AlcoAPI.Models.Mapping
{
    public class InvoiceMap : IEntityTypeConfiguration<Entities.Invoice>
    {
        public InvoiceMap() { }

        public void Configure(EntityTypeBuilder<Entities.Invoice> builder) 
        {
            //table
            builder
                .ToTable("invoice");

            //key
            builder
                .HasKey(t => t.InvoiceId);

            //properties
            builder
                .Property(t => t.InvoiceId)
                .IsRequired()
                .HasColumnName("invoice_id")
                .HasColumnType("integer")
                .ValueGeneratedOnAdd();

            builder
                .Property(t => t.ClientId)
                .HasColumnName("client_id")
                .HasColumnType("integer");

            builder
                .Property(t => t.Products)
                .HasColumnName("products")
                .HasColumnType("character varying");

            builder
                .Property(t => t.Total)
                .HasColumnName("total")
                .HasColumnType("money");

            builder
                .Property(t => t.DateCreation)
                .HasColumnName("date_creation")
                .HasColumnType("date");


            //relationship
            builder.HasOne(t => t.Client)
                .WithMany(t => t.Invoice)
                .HasForeignKey(t => t.ClientId);
        }
    }
}
