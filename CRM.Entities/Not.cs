namespace CRM.Entities
{
    public class Not
    {
        public int NotId { get; set; }
        public int? MusteriId { get; set; }
        public int? FirmaId { get; set; }
        public int? FirsatId { get; set; }
        public string? NotBasligi { get; set; }
        public string NotIcerigi { get; set; } = string.Empty;
        public int OlusturanKullaniciId { get; set; }
        public DateTime OlusturmaTarihi { get; set; } = DateTime.Now;
    }
}