namespace CRM.Entities
{
    public class Kullanici
    {
        public int KullaniciId { get; set; }
        public string Ad { get; set; } = string.Empty;
        public string Soyad { get; set; } = string.Empty;
        public string Eposta { get; set; } = string.Empty;
        public string SifreHash { get; set; } = string.Empty;
        public int RolId { get; set; }
        public bool AktifMi { get; set; } = true;
        public DateTime OlusturmaTarihi { get; set; } = DateTime.Now;
    }
}