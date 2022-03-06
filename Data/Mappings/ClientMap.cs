using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Mappings
{
    public class ClientMap : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.ToTable("Client");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Name).IsRequired().HasMaxLength(100);
            builder.Property(c => c.Address).HasMaxLength(80);
            builder.Property(c => c.HomeNumber).HasMaxLength(8);
            builder.Property(c => c.District).HasMaxLength(60);
            builder.Property(c => c.Email).HasMaxLength(60);
            builder.Property(c => c.Observation).HasMaxLength(1000);

            //"IsUnique - Do not write a repeated name in the database "
            //Creates index for the cpf field
            builder.Property(c => c.Cpf).HasMaxLength(15);
            builder.HasIndex(c => c.Cpf).IsUnique();

            builder.Property(c => c.Rg).HasMaxLength(12);
            builder.Property(c => c.PhoneNumber).HasMaxLength(15);
            builder.Property(c => c.CellNumber).HasMaxLength(15);

            //Enum
            builder.Property(c => c.Situation).IsRequired().HasDefaultValueSql("0");

            //Relationship
            builder.HasOne(c => c.State).WithMany(c => c.Clients).HasForeignKey(c => c.StateId);
            builder.HasOne(c => c.City).WithMany(c => c.Clients).HasForeignKey(c => c.CityId);
        }
    }
}
