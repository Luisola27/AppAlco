using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AlcoAPI.Models.Mapping
{
    public class TypeMap : IEntityTypeConfiguration<Entities.Type>
    {
        public TypeMap() { }

        public void Configure(EntityTypeBuilder<Entities.Type> builder)
        {
            //table
            builder
                .ToTable("type");

            //key
            builder
                .HasKey(t => t.TypeId);

            //properties
            builder
                .Property(t => t.TypeId)
                .IsRequired()
                .HasColumnName("type_id")
                .HasColumnType("integer")
                .ValueGeneratedOnAdd();

            builder
                .Property(t => t.Name)
                .HasColumnName("name")
                .HasColumnType("text");
        }
    }
}
