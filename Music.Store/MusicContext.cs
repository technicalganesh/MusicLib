using Microsoft.EntityFrameworkCore;
using Music.Entities;
namespace Music.Store {
    public class MusicContext : DbContext {

        public MusicContext (DbContextOptions<MusicContext> options) : base (options) {

        }

        public DbSet<Album> Albums { get; set; }
        public DbSet<Composer> Composers {get;set;}

        protected override void OnModelCreating (ModelBuilder modelBuilder) {
            modelBuilder.Entity<Album>().HasKey (x => x.Id);
            modelBuilder.Entity<Composer>().HasKey( x => x.Id);
            modelBuilder.Entity<Composer>().HasMany(x => x.Albums).WithOne(y => y.ComposerId);
        }
    }
}