namespace CRM.Entities
{
    public class Aktivite
    {
        public int AktiviteId { get; set; }
        public int? MusteriId { get; set; }
        public int? FirsatId { get; set; }
        public string AktiviteTipi { get; set; } = string.Empty;
        public string Konu { get; set; } = string.Empty;
        public string? Aciklama { get; set; }
        public string AktiviteDurumu { get; set; } = "Bekliyor";
        public DateTime AktiviteTarihi { get; set; }
        public int OlusturanKullaniciId { get; set; }
    }
}