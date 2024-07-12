using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AlcoAPI.Models.Mapping
{
    public class CategoryMap : IEntityTypeConfiguration<Entities.Category>
    {
        public CategoryMap() { }

        public void Configure(EntityTypeBuilder<Entities.Category> builder)
        {
            //table
            builder
                .ToTable("category");

            //key
            builder
                .HasKey(t => t.CategoryId);

            //properties
            builder
                .Property(t => t.CategoryId)
                .IsRequired()
                .HasColumnName("category_id")
                .HasColumnType("integer")
                .ValueGeneratedOnAdd();

            builder
                .Property(t => t.Name)
                .HasColumnName("name")
                .HasColumnType("text");
        }
    }
}
