namespace CRM.DTO
{
    public class UrunDto
    {
        public int UrunId { get; set; }
        public int KategoriId { get; set; }
        public string UrunAdi { get; set; } = string.Empty;
        public decimal BirimFiyat { get; set; }
        public decimal KdvOrani { get; set; }
        public bool AktifMi { get; set; }
    }
}