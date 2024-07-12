using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AlcoAPI.Models.Mapping
{
    public class CategoryTypeMap : IEntityTypeConfiguration<Entities.CategoryType>
    {
        public CategoryTypeMap() { }

        public void Configure(EntityTypeBuilder<Entities.CategoryType> builder)
        {
            //table
            builder.ToTable("category_type");

            builder.HasKey(t => new {t.CategoryId, t.TypeId});

            //properties
            builder
                .Property(t => t.CategoryId)
                .IsRequired()
                .HasColumnName("category_id")
                .HasColumnType("integer")
                .ValueGeneratedOnAdd();

            builder
                .Property(t => t.TypeId)
                .IsRequired()
                .HasColumnName("type_id")
                .HasColumnType("integer")
                .ValueGeneratedOnAdd();

            //relationship
            builder
                .HasOne(t => t.Category)
                .WithMany(t => t.CategoryTypes)
                .HasForeignKey(t => t.CategoryId);

            builder
                .HasOne(t => t.Type)
                .WithMany(t => t.CategoryTypes)
                .HasForeignKey(t => t.TypeId);
        }
    }
}
