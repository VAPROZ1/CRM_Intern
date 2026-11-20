namespace CRM.Entities
{
    public class Firsat
    {
        public int FirsatId { get; set; }
        public int MusteriId { get; set; }
        public string FirsatBasligi { get; set; } = string.Empty;
        public string? Aciklama { get; set; }
        public decimal? TahminiTutar { get; set; }
        public string FirsatDurumu { get; set; } = "Yeni";
        public string? Kaynak { get; set; }
        public int SorumluKullaniciId { get; set; }
        public DateTime? BeklenenKapanisTarihi { get; set; }
        public DateTime OlusturmaTarihi { get; set; } = DateTime.Now;
    }
}