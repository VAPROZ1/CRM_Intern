namespace CRM.Entities
{
    public class Satis
    {
        public int SatisId { get; set; }
        public int TeklifId { get; set; }
        public int MusteriId { get; set; }
        public DateTime SatisTarihi { get; set; } = DateTime.Now;
        public decimal ToplamTutar { get; set; }
        public string OdemeDurumu { get; set; } = "Bekliyor";
        public string? Aciklama { get; set; }
    }
}