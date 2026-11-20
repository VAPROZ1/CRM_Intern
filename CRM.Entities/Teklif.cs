namespace CRM.Entities
{
    public class Teklif
    {
        public int TeklifId { get; set; }
        public int MusteriId { get; set; }
        public int? FirsatId { get; set; }
        public string TeklifNo { get; set; } = string.Empty;
        public DateTime TeklifTarihi { get; set; } = DateTime.Now;
        public DateTime? GecerlilikTarihi { get; set; }
        public decimal ToplamTutar { get; set; }
        public string TeklifDurumu { get; set; } = "Taslak";
    }
}