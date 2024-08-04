using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Item> Items { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Playlist> Playlists { get; set; }
        public DbSet<User> Users { get; set; }


        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            ////Seed data
            //modelBuilder.Entity<Artist>().HasData(
            //    new Artist { Id = 1, Name = "Depeche Mode"}
            //);
            //modelBuilder.Entity<Artist>().HasData(
            //    new Song { Id = 1, Title = "Never Let Me Down Again", ArtistId = 1}
            //);  
        }
    }
}