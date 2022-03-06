using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Mappings
{
    public class StateMap : IEntityTypeConfiguration<State>
    {
        public void Configure(EntityTypeBuilder<State> builder)
        {
            builder.ToTable("State");
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Name).HasMaxLength(60);
            builder.Property(s => s.Uf).HasMaxLength(2);

            //Enum
            builder.Property(s => s.Situation).IsRequired().HasDefaultValueSql("0");
        }
    }
}
