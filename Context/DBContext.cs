using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UnisysRestApi.Models
{
    public partial class DBContext : DbContext
    {
        public DBContext()
        {
        }

        public DBContext(DbContextOptions<DBContext> options)
            : base(options)
        {

        }

        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Favorite> Favorite { get; set; }
        public virtual DbSet<Movie> Movie { get; set; }

 


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>(entity =>
            {
                entity.HasKey(e => e.IdCard)
                    .HasName("PK__client__C71FE367175FB5C7");

                entity.Property(e => e.IdCard).ValueGeneratedNever();

                entity.Property(e => e.LastName)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Name)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<Favorite>(entity =>
            {
                entity.HasKey(e => new { e.ClientId, e.MovieId })
                    .HasName("PK__favorite__371D7B509A98CE07");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Favorite)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("client_id_FK");

                entity.HasOne(d => d.Movie)
                    .WithMany(p => p.Favorite)
                    .HasForeignKey(d => d.MovieId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("movie_id_FK");
            });

            modelBuilder.Entity<Movie>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .HasComment("");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
