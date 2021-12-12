﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataBase.Model_Config
{
    class customerss_Config : IEntityTypeConfiguration<customerss>
    {
        public void Configure(EntityTypeBuilder<customerss> builder)
        {
            builder.HasKey(c => c.customers_ID);
            builder.Property(c => c.customers_ID).HasColumnName("customers Id");
            builder.Property(c => c.First_Name).HasColumnName("First Name").IsRequired().HasMaxLength(25).HasColumnType("nvarchar");
            builder.Property(c => c.last_Name).HasColumnName("Last Name").IsRequired().HasMaxLength(25).HasColumnType("nvarchar");
            builder.Property(c => c.Email).IsRequired().HasColumnType("nvarchar").HasMaxLength(25);
            builder.Property(c => c.Birthdate).IsRequired().HasColumnType("smalldatetime");
            builder.Property(c => c.Password).IsRequired().HasMaxLength(100);
            builder.Property(c => c.Phone_Number).IsRequired().HasColumnName("Phone number");
            builder.HasMany(c => c.Address).WithOne(c => c.customers).HasForeignKey(c => c.customers_ID);

        }
    }
}
