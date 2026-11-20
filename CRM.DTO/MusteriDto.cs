namespace CRM.DTO
{
    public class MusteriDto
    {
        public int MusteriId { get; set; }
        public string Ad { get; set; } = string.Empty;
        public string Soyad { get; set; } = string.Empty;
        public string Telefon { get; set; } = string.Empty;
        public string? Eposta { get; set; }
        public int? FirmaId { get; set; }
        public string MusteriDurumu { get; set; } = string.Empty;
    }
}