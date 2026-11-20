using CRM.Entities;

namespace CRM.Business.Abstract
{
    public interface IFirmaService
    {
        List<Firma> GetAll();          // Tüm firmaları getir
        Firma GetById(int id);         // ID'ye göre tek firma getir
        void Add(Firma firma);       // Yeni firma ekle
        void Update(Firma firma);    // Firma güncelle
        void Delete(int id);           // Firma sil
    }
}