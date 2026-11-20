namespace CRM.Entities
{
    public class Kategori
    {
        public int KategoriId { get; set; }
        public string KategoriAdi { get; set; } = string.Empty;
        public string? Aciklama { get; set; }
        public bool AktifMi { get; set; } = true;
    }
}