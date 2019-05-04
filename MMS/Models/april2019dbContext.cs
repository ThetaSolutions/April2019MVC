using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MMS.Models
{
    public partial class april2019dbContext : DbContext
    {
        public april2019dbContext()
        {
        }

        public april2019dbContext(DbContextOptions<april2019dbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Movie> Movie { get; set; }


//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Server=LENOVO\\SQLEXPRESS;Database=april2019db;Trusted_Connection=True;User ID=sa; Password=theta;");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.1-servicing-10028");

            modelBuilder.Entity<Movie>(entity =>
            {
                entity.ToTable("movie");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Director)
                    .HasColumnName("director")
                    .HasMaxLength(50);

                entity.Property(e => e.Industry)
                    .HasColumnName("industry")
                    .HasMaxLength(50);

                entity.Property(e => e.Language)
                    .HasColumnName("language")
                    .HasMaxLength(50);

                entity.Property(e => e.LeadActor)
                    .HasColumnName("lead_actor")
                    .HasMaxLength(50);

                entity.Property(e => e.LeadActress)
                    .HasColumnName("lead_actress")
                    .HasMaxLength(50);

                entity.Property(e => e.Length).HasColumnName("length");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.ReleaseDate)
                    .HasColumnName("release_date")
                    .HasColumnType("datetime");
            });
        }
    }
}
