using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AnkitTest
{
    internal class CTEResultsConfiguration : IEntityTypeConfiguration<CTEResult>
    {
        public void Configure(EntityTypeBuilder<CTEResult> builder)
        {
            builder.ToTable("cteResult","scratch");
            builder.HasKey("Id");
            builder.Property(e => e.RoomClassId).HasColumnName("RoomClassID");
            builder.Property(e => e.RoomClassName).HasColumnName("RoomClassName");
        }
    }
}