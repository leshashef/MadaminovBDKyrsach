using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MadaminovBDKyrsach.Models
{
    public partial class StudentPerformanceContext : DbContext
    {
        public StudentPerformanceContext()
        {
        }

        public StudentPerformanceContext(DbContextOptions<StudentPerformanceContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CardReport> CardReport { get; set; }
        public virtual DbSet<Chairs> Chairs { get; set; }
        public virtual DbSet<Facultys> Facultys { get; set; }
        public virtual DbSet<Students> Students { get; set; }
        public virtual DbSet<StudyGroup> StudyGroup { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-QFHLJ6R;Initial Catalog=StudentPerformance;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CardReport>(entity =>
            {
                entity.Property(e => e.Subjects)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.CardReport)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CardRepor__Group__2F10007B");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.CardReport)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CardRepor__Stude__300424B4");
            });

            modelBuilder.Entity<Chairs>(entity =>
            {
                entity.Property(e => e.NameChair)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ZamDeanFio)
                    .IsRequired()
                    .HasColumnName("ZamDeanFIO")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Faculty)
                    .WithMany(p => p.Chairs)
                    .HasForeignKey(d => d.FacultyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Chairs__FacultyI__267ABA7A");
            });

            modelBuilder.Entity<Facultys>(entity =>
            {
                entity.Property(e => e.DeanFio)
                    .IsRequired()
                    .HasColumnName("DeanFIO")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NameFaculty)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Students>(entity =>
            {
                entity.Property(e => e.Adress)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BirthDay).HasColumnType("date");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SecondName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Students__GroupI__2C3393D0");
            });

            modelBuilder.Entity<StudyGroup>(entity =>
            {
                entity.Property(e => e.CoursStudy)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NameGroup)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.YearOfBeginStudy).HasColumnType("date");

                entity.HasOne(d => d.Chair)
                    .WithMany(p => p.StudyGroup)
                    .HasForeignKey(d => d.ChairId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__StudyGrou__Chair__29572725");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
