namespace CRM.DTO
{
    public class FirmaDto
    {
        public int FirmaId { get; set; }
        public string FirmaAdi { get; set; } = string.Empty;
        public string? VergiNo { get; set; }
        public string? Telefon { get; set; }
        public string? Eposta { get; set; }
        public bool AktifMi { get; set; }
    }
}