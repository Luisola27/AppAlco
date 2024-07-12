using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace AlcoAPI.Models.Mapping
{
    public sealed class GuaroMap : IEntityTypeConfiguration<Entities.Guaro>
    {
        public GuaroMap() { }

        public void Configure(EntityTypeBuilder<Entities.Guaro> builder)
        {
            //table
            builder
                .ToTable("guaro");

            //key
            builder
                .HasKey(t => t.GuaroId);

            //properties
            builder
                .Property(t => t.GuaroId)
                .IsRequired()
                .HasColumnName("guaro_id")
                .HasColumnType("integer")
                .ValueGeneratedOnAdd();

            builder
                .Property(t => t.Name)
                .HasColumnName("name")
                .HasColumnType("text");

            builder
                .Property(t => t.Code)
                .HasColumnName("code")
                .HasColumnType("text");

            builder
                .Property(t => t.Active)
                .HasColumnName("active")
                .HasColumnType("integer");

            builder
                .Property(t => t.Value)
                .HasColumnName("value")
                .HasColumnType("money");

            builder
                .Property(t => t.Image)
                .HasColumnName("image")
                .HasColumnType("text");

            builder
                .Property(t => t.CategoryId)
                .HasColumnName("category_id")
                .HasColumnType("integer");

            builder
                .Property(t => t.TypeId)
                .HasColumnName("type_id")
                .HasColumnType("integer");



            //relationship
            builder
                .HasOne(t => t.Category)
                .WithMany(t => t.Guaro)
                .HasForeignKey(t => t.CategoryId);

            builder
                .HasOne(t => t.Type)
                .WithMany(t => t.Guaro)
                .HasForeignKey(t => t.TypeId);
        }
    }
}
