namespace CRM.DTO
{
    public class FirsatDto
    {
        public int FirsatId { get; set; }
        public int MusteriId { get; set; }
        public string FirsatBasligi { get; set; } = string.Empty;
        public decimal? TahminiTutar { get; set; }
        public string FirsatDurumu { get; set; } = string.Empty;
        public int SorumluKullaniciId { get; set; }
    }
}