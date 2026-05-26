using System.Data.Entity;

namespace TravelTripProje.Models.Siniflar
{
    public class Context : DbContext
    {
        public Context() : base("name=Context") { }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Yorumlar> Yorumlars { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Adres> Adres { get; set; }
        public DbSet<Anasayfa> Anasayfas { get; set; }
        public DbSet<Hakkimizda> Hakkimizdas { get; set; }
        public DbSet<iletisim> Iletisims { get; set; }

    }
}