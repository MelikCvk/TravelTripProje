using System.Data.Entity;

namespace TravelTripProje.Models.Siniflar
{
    public class Context : DbContext
    {
        public Context() : base("name=Context") { }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Yorumlar> Yorumlars { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Adres> Adresler { get; set; }
        public DbSet<Anasayfa> Anasayfalar { get; set; }
        public DbSet<Hakkimizda> Hakkimizdalar { get; set; }
        public DbSet<iletisim> Iletisimler { get; set; }
    }
}