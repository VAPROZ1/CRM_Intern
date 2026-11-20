using Microsoft.EntityFrameworkCore;
using CRM.Entities; // Tablolarımızı görebilmek için

namespace CRM.DataAccess
{
    public class CrmDbContext : DbContext
    {
        public CrmDbContext(DbContextOptions<CrmDbContext> options) : base(options)
        {
        }

        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Rol> Roller { get; set; }
        public DbSet<Firma> Firmalar { get; set; }
        public DbSet<Musteri> Musteriler { get; set; }
        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Firsat> Firsatlar { get; set; }
        public DbSet<Teklif> Teklifler { get; set; }
        public DbSet<TeklifKalemi> TeklifKalemleri { get; set; }
        public DbSet<Satis> Satislar { get; set; }
        public DbSet<Aktivite> Aktiviteler { get; set; }
        public DbSet<DestekTalebi> DestekTalepleri { get; set; }
        public DbSet<Not> Notlar { get; set; }
    }
}