namespace CRM.Entities
{
    public class Rol
    {
        public int RolId { get; set; }
        public string RolAdi { get; set; } = string.Empty;
        public string? Aciklama { get; set; }
    }
}