﻿using Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Configurations
{
    public class AccountConfiguration : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.ToTable(nameof(Account));
            builder.Property(x => x.AvatarURL).IsRequired(false);
            builder.Property(x => x.Gender).IsRequired(false);
            builder.Property(x => x.Fullname).IsRequired(false); 
            builder.Property(x => x.Dob).IsRequired(false);
            builder.Property(x => x.isAccountActive).IsRequired();

            #region config relation
            #endregion


        }
    }
}
