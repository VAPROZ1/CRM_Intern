namespace CRM.DTO
{
    public class KullaniciDto
    {
        public int KullaniciId { get; set; }
        public string Ad { get; set; } = string.Empty;
        public string Soyad { get; set; } = string.Empty;
        public string Eposta { get; set; } = string.Empty;
        public int RolId { get; set; }
        public bool AktifMi { get; set; }
    }
}