using CRM.Entities;

namespace CRM.Business.Abstract
{
    public interface IMusteriService
    {
        List<Musteri> GetAll();          // Tüm müşterileri getir
        Musteri GetById(int id);         // ID'ye göre tek müşteri getir
        void Add(Musteri musteri);       // Yeni müşteri ekle
        void Update(Musteri musteri);    // Müşteri güncelle
        void Delete(int id);             // Müşteri sil
    }
}