using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Mappings
{
    public class EmployeeMap : IEntityTypeConfiguration<Employee>
    {

        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employee");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Name).IsRequired().HasMaxLength(100);
            builder.Property(e => e.Address).HasMaxLength(100);
            builder.Property(e => e.HomeNumber).HasMaxLength(8);
            builder.Property(e => e.District).HasMaxLength(60);
            builder.Property(e => e.Email).HasMaxLength(60);
            builder.Property(e => e.Observation).HasMaxLength(1000);

            //"IsUnique - Do not write a repeated name in the database"
            //Creates index for the cpf field
            builder.Property(e => e.Cpf).IsRequired().HasMaxLength(15);
            builder.HasIndex(e => e.Cpf).IsUnique();

            builder.Property(e => e.Rg).HasMaxLength(12);
            builder.Property(e => e.PhoneNumber).HasMaxLength(15);
            builder.Property(e => e.CellNumber).HasMaxLength(15);

            //Enum
            builder.Property(e => e.Situation).IsRequired().HasDefaultValueSql("0");

            //Relationship
            builder.HasOne(e => e.State).WithMany(e => e.Employees).HasForeignKey(e => e.StateId);
            builder.HasOne(e => e.City).WithMany(e => e.Employees).HasForeignKey(e => e.CityId);
        }
    }
}
