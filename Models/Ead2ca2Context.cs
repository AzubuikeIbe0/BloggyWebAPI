using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BloggyWebAPI.Models;

public partial class Ead2ca2Context : DbContext
{
    public Ead2ca2Context()
    {
    }

    public Ead2ca2Context(DbContextOptions<Ead2ca2Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Article> Articles { get; set; }

    public virtual DbSet<Author> Authors { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Article>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Articles__3213E83F664B0E18");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AuthorId).HasColumnName("authorId");
            entity.Property(e => e.Body)
                .HasColumnType("text")
                .HasColumnName("body");
            entity.Property(e => e.Category)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("category");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("createdAt");
            entity.Property(e => e.ImageUrl)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("imageUrl");
            entity.Property(e => e.Subtitle)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("subtitle");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("title");
            entity.Property(e => e.Views).HasColumnName("views");

            entity.HasOne(d => d.Author).WithMany(p => p.Articles)
                .HasForeignKey(d => d.AuthorId)
                .HasConstraintName("FK__Articles__author__5EBF139D");
        });

        modelBuilder.Entity<Author>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Authors__3213E83FA7511138");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ImageUrl)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("imageUrl");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
