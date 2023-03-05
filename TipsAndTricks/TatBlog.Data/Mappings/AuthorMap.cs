﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagBlog.Core.Entities;
namespace TagBlog.Data.Mappings;

public class AuthorMap:IEntityTypeConfiguration<Author>
{
    public void Configure(EntityTypeBuilder<Author> builder)
    {
        builder.ToTable("Authors");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.FullName)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(x => x.UrlSlug)
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(x => x.ImageUrl)
           .HasMaxLength(500);

        builder.Property(x => x.Email)
            .HasMaxLength(150);

        builder.Property(x => x.JoinedDate)
            .HasColumnType("datetime");

        builder.Property(x => x.Notes)
            .HasMaxLength(500);

    }
}
