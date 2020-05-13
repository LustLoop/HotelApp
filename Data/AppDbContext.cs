using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Hotel.Models;

namespace Hotel.Data
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=blogging.db");


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Settlement>()
                .HasKey(s => new { s.ClientId, s.RoomId });

            modelBuilder.Entity<Settlement>()
                .HasOne(r => r.Room)
                .WithMany(s => s.Settlements)
                .HasForeignKey(r => r.RoomId);

            modelBuilder.Entity<Settlement>()
                .HasOne(c => c.Client)
                .WithMany(s => s.Settlements)
                .HasForeignKey(c => c.ClientId);
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Settlement> Settlements { get; set; }
    }
}
