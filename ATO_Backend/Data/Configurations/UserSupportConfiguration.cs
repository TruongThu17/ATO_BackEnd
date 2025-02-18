using Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Configurations
{
    public class UserSupportConfiguration : IEntityTypeConfiguration<UserSupport>
    {
        public void Configure(EntityTypeBuilder<UserSupport> builder)
        {
            builder.ToTable(nameof(UserSupport));
            builder.HasKey(x => x.SupportId);
            builder.Property(x => x.IssueType).IsRequired();
            builder.Property(x => x.SupportMessage).IsRequired();
            builder.Property(x => x.RequestDate).IsRequired();
            //builder.Property(x => x.ResponeBy).IsRequired();
            builder.Property(x => x.IsResolved).IsRequired();

            builder.Property(x => x.ResponseDate).IsRequired(false);
            builder.Property(x => x.UpdatedDate).IsRequired(false);
            #region config relation
            builder.HasOne(x => x.Account)
               .WithMany(c => c.RequestSupports)
               .HasForeignKey(x => x.AccoutId);
            //builder.HasOne(x => x.Account)
            //   .WithMany(c => c.RequestSupports)
            //   .HasForeignKey(x => x.ResponeBy);
            #endregion
        }
    }
}
