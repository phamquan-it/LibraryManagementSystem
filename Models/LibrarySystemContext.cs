using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.Models;

public partial class LibrarySystemContext : DbContext
{
    public LibrarySystemContext()
    {
    }

    public LibrarySystemContext(DbContextOptions<LibrarySystemContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TblAdmin> TblAdmins { get; set; }

    public virtual DbSet<TblBook> TblBooks { get; set; }

    public virtual DbSet<TblTransaction> TblTransactions { get; set; }

    public virtual DbSet<TblUser> TblUsers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TblAdmin>(entity =>
        {
            entity.HasKey(e => e.AdminId);

            entity.ToTable("tblAdmins");

            entity.Property(e => e.AdminEmail)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AdminName).HasMaxLength(50);
            entity.Property(e => e.AdminPass)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblBook>(entity =>
        {
            entity.HasKey(e => e.BookId);

            entity.ToTable("tblBooks");

            entity.Property(e => e.BookAuthor).HasMaxLength(50);
            entity.Property(e => e.BookCategory).HasMaxLength(50);
            entity.Property(e => e.BookIsbn)
                .HasMaxLength(50)
                .HasColumnName("BookISBN");
            entity.Property(e => e.BookPub).HasMaxLength(50);
            entity.Property(e => e.BookTitle).HasMaxLength(250);
            entity.Property(e => e.DateAdded)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblTransaction>(entity =>
        {
            entity.HasKey(e => e.TranId);

            entity.ToTable("tblTransactions");

            entity.Property(e => e.BookIsbn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BookISBN");
            entity.Property(e => e.BookTitle)
                .HasMaxLength(250)
                .HasColumnName("BookTItle");
            entity.Property(e => e.TranStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TransDate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.UserName).HasMaxLength(50);
        });

        modelBuilder.Entity<TblUser>(entity =>
        {
            entity.HasKey(e => e.UserId);

            entity.ToTable("tblUsers");

            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.UserDep).HasMaxLength(10);
            entity.Property(e => e.UserEmail)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserGender).HasMaxLength(10);
            entity.Property(e => e.UserName).HasMaxLength(50);
            entity.Property(e => e.UserPass)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
