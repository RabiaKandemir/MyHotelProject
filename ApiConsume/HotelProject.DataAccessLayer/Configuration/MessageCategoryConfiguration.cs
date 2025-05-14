using HotelProject.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelProject.DataAccessLayer.Configuration
{
    public class MessageCategoryConfiguration : IEntityTypeConfiguration<MessageCategory>
    {
        public void Configure(EntityTypeBuilder<MessageCategory> builder)
        {
            builder.HasMany(b => b.Contacts);
        }
    }
}
