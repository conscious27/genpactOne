using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PassportAPI.Models;

public partial class PassportDbContext : DbContext
{
    public PassportDbContext()
    {
    }

    public PassportDbContext(DbContextOptions<PassportDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Passport> Passports { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=DESKTOP-MFEN465;database=PassportDb;trusted_connection=true;trustservercertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Passport>(entity =>
        {
            entity.HasKey(e => e.Pid).HasName("PK__Passport__C577554063959CC3");

            entity.ToTable("Passport");

            entity.HasIndex(e => e.Pnumber, "UQ__Passport__DDE0878CBF5F13E1").IsUnique();

            entity.Property(e => e.Pid)
                .ValueGeneratedNever()
                .HasColumnName("PId");
            entity.Property(e => e.PholderName)
                .HasMaxLength(50)
                .HasColumnName("PHolderName");
            entity.Property(e => e.Pnumber)
                .HasMaxLength(10)
                .HasColumnName("PNumber");
            entity.Property(e => e.PofficeCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("POfficeCode");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
