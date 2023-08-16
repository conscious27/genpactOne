using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BookApp.Models;

public partial class BookDbContext : DbContext
{
    public BookDbContext()
    {
    }

    public BookDbContext(DbContextOptions<BookDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Author> Authors { get; set; }

    public virtual DbSet<Book> Books { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Publisher> Publishers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=DESKTOP-MFEN465;database=BookDb;trusted_connection=true;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Author>(entity =>
        {
            entity.HasKey(e => e.Aid).HasName("PK__Author__C690062881D940E4");

            entity.ToTable("Author");

            entity.HasIndex(e => e.Author1, "UQ__Author__12C0B644B922DB5D").IsUnique();

            entity.Property(e => e.Aid)
                .ValueGeneratedNever()
                .HasColumnName("AId");
            entity.Property(e => e.Author1)
                .HasMaxLength(50)
                .HasColumnName("Author");
        });

        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasKey(e => e.Bid).HasName("PK__Book__C6DE0CC1053C3693");

            entity.ToTable("Book");

            entity.Property(e => e.Bid)
                .ValueGeneratedNever()
                .HasColumnName("BId");
            entity.Property(e => e.BookName).HasMaxLength(50);

            entity.HasOne(d => d.AuthorNavigation).WithMany(p => p.Books)
                .HasForeignKey(d => d.Author)
                .HasConstraintName("FK__Book__Author__47DBAE45");

            entity.HasOne(d => d.CategoryNavigation).WithMany(p => p.Books)
                .HasForeignKey(d => d.Category)
                .HasConstraintName("FK__Book__Category__49C3F6B7");

            entity.HasOne(d => d.PublisherNavigation).WithMany(p => p.Books)
                .HasForeignKey(d => d.Publisher)
                .HasConstraintName("FK__Book__Publisher__48CFD27E");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Cid).HasName("PK__Category__C1F8DC39FFC8E13B");

            entity.ToTable("Category");

            entity.HasIndex(e => e.Category1, "UQ__Category__4BB73C322CEB9566").IsUnique();

            entity.Property(e => e.Cid)
                .ValueGeneratedNever()
                .HasColumnName("CId");
            entity.Property(e => e.Category1)
                .HasMaxLength(50)
                .HasColumnName("Category");
        });

        modelBuilder.Entity<Publisher>(entity =>
        {
            entity.HasKey(e => e.Pid).HasName("PK__Publishe__C577554018C78A87");

            entity.ToTable("Publisher");

            entity.HasIndex(e => e.Publisher1, "UQ__Publishe__C25E15ABEA306035").IsUnique();

            entity.Property(e => e.Pid)
                .ValueGeneratedNever()
                .HasColumnName("PId");
            entity.Property(e => e.Publisher1)
                .HasMaxLength(50)
                .HasColumnName("Publisher");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
