using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Mappings
{
    public class ProviderMap : IEntityTypeConfiguration<Provider>
    {
        public void Configure(EntityTypeBuilder<Provider> builder)
        {
            builder.ToTable("Provider");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name).IsRequired().HasMaxLength(100);
            builder.Property(p => p.Address).HasMaxLength(80);
            builder.Property(p => p.HomeNumber).HasMaxLength(8);
            builder.Property(p => p.District).HasMaxLength(60);
            builder.Property(p => p.Email).HasMaxLength(60);
            builder.Property(p => p.Observation).HasMaxLength(1000);

            //"IsUnique - Do not write a repeated name in the database "
            //Creates index for the cnpj field
            builder.Property(p => p.Cnpj).HasMaxLength(18);
            builder.HasIndex(p => p.Cnpj).IsUnique();
            builder.Property(p => p.PhoneNumber).HasMaxLength(15);
            builder.Property(p => p.CellNumber).HasMaxLength(15);

            //Enum
            builder.Property(p => p.Situation).IsRequired().HasDefaultValueSql("0");

            //Relationship
            builder.HasOne(p => p.State).WithMany(p => p.Providers).HasForeignKey(p => p.StateId);
            builder.HasOne(p => p.City).WithMany(p => p.Providers).HasForeignKey(p => p.CityId);
        }
    }
}
