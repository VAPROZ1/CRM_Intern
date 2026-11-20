using CRM.Entities;

namespace CRM.Business.Abstract
{
    public interface IKategoriService
    {
        List<Kategori> GetAll();
        Kategori GetById(int id);
        void Add(Kategori kategori);
        void Update(Kategori kategori);
        void Delete(int id);
    }
}