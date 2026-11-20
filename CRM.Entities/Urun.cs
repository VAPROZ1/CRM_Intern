namespace CRM.Entities
{
    public class Urun
    {
        public int UrunId { get; set; }
        public int KategoriId { get; set; }
        public string UrunAdi { get; set; } = string.Empty;
        public string? Aciklama { get; set; }
        public decimal BirimFiyat { get; set; }
        public decimal KdvOrani { get; set; } = 20;
        public bool AktifMi { get; set; } = true;
        public DateTime OlusturmaTarihi { get; set; } = DateTime.Now;
    }
}