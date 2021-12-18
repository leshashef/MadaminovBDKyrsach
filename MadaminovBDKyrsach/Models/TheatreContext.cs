using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MadaminovBDKyrsach.Models
{
    public partial class TheatreContext : DbContext
    {
        public TheatreContext()
        {
        }

        public TheatreContext(DbContextOptions<TheatreContext> options)
            : base(options)
        {
        }

        public virtual DbSet<GroupShow> GroupShow { get; set; }
        public virtual DbSet<PerformanceShow> PerformanceShow { get; set; }
        public virtual DbSet<TheatreRepertoire> TheatreRepertoire { get; set; }
        public virtual DbSet<TourSchedule> TourSchedule { get; set; }
        public virtual DbSet<Worker> Worker { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
          
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<GroupShow>(entity =>
            {
                entity.Property(e => e.TypeRole)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.PerformanceShow)
                    .WithMany(p => p.GroupShow)
                    .HasForeignKey(d => d.PerformanceShowId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__GroupShow__Perfo__3C69FB99");

                entity.HasOne(d => d.Worker)
                    .WithMany(p => p.GroupShow)
                    .HasForeignKey(d => d.WorkerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__GroupShow__Worke__3D5E1FD2");
            });

            modelBuilder.Entity<PerformanceShow>(entity =>
            {
                entity.Property(e => e.Author)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NameShow)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Style)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TypeShow)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.ConductorDirector)
                    .WithMany(p => p.PerformanceShowConductorDirector)
                    .HasForeignKey(d => d.ConductorDirectorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Performan__Condu__36B12243");

                entity.HasOne(d => d.DirectorProducer)
                    .WithMany(p => p.PerformanceShowDirectorProducer)
                    .HasForeignKey(d => d.DirectorProducerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Performan__Direc__34C8D9D1");

                entity.HasOne(d => d.ProductionDesigner)
                    .WithMany(p => p.PerformanceShowProductionDesigner)
                    .HasForeignKey(d => d.ProductionDesignerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Performan__Produ__35BCFE0A");
            });

            modelBuilder.Entity<TheatreRepertoire>(entity =>
            {
                entity.Property(e => e.PeriodEnd).HasColumnType("date");

                entity.Property(e => e.PeriodStart).HasColumnType("date");

                entity.Property(e => e.WorkDays)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.PerformanceShow)
                    .WithMany(p => p.TheatreRepertoire)
                    .HasForeignKey(d => d.PerformanceShowId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TheatreRe__Perfo__403A8C7D");
            });

            modelBuilder.Entity<TourSchedule>(entity =>
            {
                entity.Property(e => e.DateEnd).HasColumnType("date");

                entity.Property(e => e.DateStart).HasColumnType("date");

                entity.Property(e => e.Locations)
                    .IsRequired()
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.NameTourSchedule)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.PerformanceShow)
                    .WithMany(p => p.TourSchedule)
                    .HasForeignKey(d => d.PerformanceShowId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TourSched__Perfo__4316F928");
            });

            modelBuilder.Entity<Worker>(entity =>
            {
                entity.Property(e => e.AddressWorker)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CityWorker)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JobPost)
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

                entity.Property(e => e.YearBirthDay).HasColumnType("date");

                entity.Property(e => e.YearOfStartWork).HasColumnType("date");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
