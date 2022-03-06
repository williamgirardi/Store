using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Mappings
{
    public class CityMap : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.ToTable("City");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Name).IsRequired().HasMaxLength(100);

            //Enum
            builder.Property(c => c.Situation).IsRequired().HasDefaultValueSql("0");

            //Relationship
            builder.HasOne(c => c.State).WithMany(c => c.Cities).HasForeignKey(c => c.StateId);
        }
    }
}
