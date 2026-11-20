namespace CRM.Entities
{
    public class Musteri
    {
        public int MusteriId { get; set; }
        public string Ad { get; set; } = string.Empty;
        public string Soyad { get; set; } = string.Empty;
        public string Telefon { get; set; } = string.Empty;
        public string? Eposta { get; set; }
        public int? FirmaId { get; set; }
        public string MusteriDurumu { get; set; } = "Potansiyel";
        public string? Kaynak { get; set; }
        public int? SorumluKullaniciId { get; set; }
        public DateTime OlusturmaTarihi { get; set; } = DateTime.Now;
    }
}