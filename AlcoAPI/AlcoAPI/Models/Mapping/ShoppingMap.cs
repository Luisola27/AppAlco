using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AlcoAPI.Models.Mapping
{
    public class ShoppingMap : IEntityTypeConfiguration<Entities.Shopping>
    {
        public ShoppingMap() { }

        public void Configure(EntityTypeBuilder<Entities.Shopping> builder) 
        {
            //table
            builder
                .ToTable("shopping");

            //key
            builder
                .HasKey(t => t.ShoppingId);

            //properties
            builder
                .Property(t => t.ShoppingId)
                .HasColumnName("shopping_id")
                .HasColumnType("integer")
                .ValueGeneratedOnAdd();

            builder
                .Property(t => t.Products)
                .HasColumnName("products")
                .HasColumnType("text");

            builder
                .Property(t => t.ClientId)
                .HasColumnName("client_id")
                .HasColumnType("text");

            builder
                .Property(t => t.CategoryId)
                .HasColumnName("category_id")
                .HasColumnType("integer");

            builder
                .Property(t => t.TypeId)
                .HasColumnName("type_id")
                .HasColumnType("integer");

            //relantionship
            builder
                .HasOne(t => t.Client)
                .WithMany(t => t.Shopping)
                .HasForeignKey(t  => t.ClientId);

            builder
                .HasOne(t => t.Category)
                .WithMany(t => t.Shopping)
                .HasForeignKey(t => t.CategoryId); 
            
            builder
                .HasOne(t => t.Type)
                .WithMany(t => t.Shopping)
                .HasForeignKey(t => t.TypeId);

        }
    }
}
