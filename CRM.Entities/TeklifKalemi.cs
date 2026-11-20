namespace CRM.Entities
{
    public class TeklifKalemi
    {
        public int TeklifKalemiId { get; set; }
        public int TeklifId { get; set; }
        public int UrunId { get; set; }
        public int Adet { get; set; }
        public decimal BirimFiyat { get; set; }
        public decimal IskontoOrani { get; set; } = 0;
        public decimal KdvOrani { get; set; } = 20;
        public decimal SatirToplami { get; set; }
    }
}