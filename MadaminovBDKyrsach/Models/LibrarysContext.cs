using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MadaminovBDKyrsach.Models
{
    public partial class LibrarysContext : DbContext
    {
        public LibrarysContext()
        {
        }

        public LibrarysContext(DbContextOptions<LibrarysContext> options)
            : base(options)
        {
        }

        public virtual DbSet<FondAddeds> FondAddeds { get; set; }
        public virtual DbSet<FondLibrary> FondLibrary { get; set; }
        public virtual DbSet<Library> Library { get; set; }
        public virtual DbSet<Literature> Literature { get; set; }
        public virtual DbSet<Workers> Workers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-QFHLJ6R;Initial Catalog=Librarys;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FondAddeds>(entity =>
            {
                entity.Property(e => e.DateCreated).HasColumnType("date");

                entity.Property(e => e.NameSource)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PublishingDate).HasColumnType("date");

                entity.Property(e => e.PublishingHouse)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Fond)
                    .WithMany(p => p.FondAddeds)
                    .HasForeignKey(d => d.FondId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__FondAdded__FondI__31EC6D26");

                entity.HasOne(d => d.Literature)
                    .WithMany(p => p.FondAddeds)
                    .HasForeignKey(d => d.LiteratureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__FondAdded__Liter__32E0915F");

                entity.HasOne(d => d.Worker)
                    .WithMany(p => p.FondAddeds)
                    .HasForeignKey(d => d.WorkerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__FondAdded__Worke__30F848ED");
            });

            modelBuilder.Entity<FondLibrary>(entity =>
            {
                entity.Property(e => e.NameFond)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Library)
                    .WithMany(p => p.FondLibrary)
                    .HasForeignKey(d => d.LibraryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__FondLibra__Libra__267ABA7A");
            });

            modelBuilder.Entity<Library>(entity =>
            {
                entity.Property(e => e.Adres)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NameLibrary)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Literature>(entity =>
            {
                entity.Property(e => e.NameType)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Workers>(entity =>
            {
                entity.Property(e => e.BirthDay).HasColumnType("date");

                entity.Property(e => e.Education)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Post)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Salary).HasColumnType("money");

                entity.Property(e => e.StartWork).HasColumnType("date");

                entity.HasOne(d => d.Library)
                    .WithMany(p => p.Workers)
                    .HasForeignKey(d => d.LibraryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Workers__Library__2E1BDC42");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
