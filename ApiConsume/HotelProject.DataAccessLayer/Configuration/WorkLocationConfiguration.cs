using HotelProject.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelProject.DataAccessLayer.Configuration
{
    public class WorkLocationConfiguration : IEntityTypeConfiguration<WorkLocation>
    {
        public void Configure(EntityTypeBuilder<WorkLocation> builder)
        {
            builder.HasMany(b => b.AppUsers);
        }
    }
}
