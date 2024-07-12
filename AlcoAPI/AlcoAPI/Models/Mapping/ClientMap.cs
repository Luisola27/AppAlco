using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AlcoAPI.Models.Mapping
{
    public class ClientMap : IEntityTypeConfiguration<Entities.Client>
    {
        public ClientMap() { }

        public void Configure(EntityTypeBuilder<Entities.Client> builder)
        {
            //table
            builder
                .ToTable("client");

            //key
            builder
                .HasKey(t => t.ClientId);

            //properties
            builder
                .Property(t => t.ClientId)
                .IsRequired()
                .HasColumnName("client_id")
                .HasColumnType("integer")
                .ValueGeneratedOnAdd();

            builder
                .Property(t => t.Name)
                .HasColumnName("name")
                .HasColumnType("text");
        }
    }
}
