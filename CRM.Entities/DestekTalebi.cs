using System.ComponentModel.DataAnnotations; // Bu kütüphaneyi eklemeyi unutma

namespace CRM.Entities
{
    public class DestekTalebi
    {
        [Key] // Entity Framework'e buranın Primary Key olduğunu söyler
        public int TalepId { get; set; }

        public int MusteriId { get; set; }
        public string Konu { get; set; } = string.Empty;
        public string Aciklama { get; set; } = string.Empty;
        public string Oncelik { get; set; } = "Orta";
        public string Durum { get; set; } = "Acik";
        public int? AtananKullaniciId { get; set; }
        public DateTime OlusturmaTarihi { get; set; } = DateTime.Now;
    }
}