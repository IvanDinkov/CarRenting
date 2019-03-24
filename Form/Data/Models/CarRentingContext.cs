using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WindowsFormsApp2.Models
{
    public partial class CarRentingContext : DbContext
    {
        public CarRentingContext()
        {
        }

        public CarRentingContext(DbContextOptions<CarRentingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Accounts> Accounts { get; set; }
        public virtual DbSet<Cars> Cars { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Data.Connection.CONNECTION_STRING);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.3-servicing-35854");

            modelBuilder.Entity<Accounts>(entity =>
            {
                entity.ToTable("accounts");

                entity.HasIndex(e => e.Username)
                    .HasName("UQ__accounts__F3DBC572208E6CC8")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasColumnName("firstname")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasColumnName("lastname")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cars>(entity =>
            {
                entity.ToTable("cars");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Brand)
                    .IsRequired()
                    .HasColumnName("brand")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CarType)
                    .IsRequired()
                    .HasColumnName("car_type")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DoorCount).HasColumnName("door_count");

                entity.Property(e => e.FuelConsumption)
                    .IsRequired()
                    .HasColumnName("fuel_consumption")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasColumnName("model")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Picture)
                    .HasColumnName("picture")
                    .HasColumnType("image");

                entity.Property(e => e.PricePerDay)
                    .HasColumnName("price_per_day")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.SeatCount).HasColumnName("seat_count");

                entity.Property(e => e.TakenBy).HasColumnName("taken_by");

                entity.Property(e => e.Transmission)
                    .IsRequired()
                    .HasColumnName("transmission")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });
        }
    }
}
