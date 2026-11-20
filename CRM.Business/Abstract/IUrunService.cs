using CRM.Entities;

namespace CRM.Business.Abstract
{
    public interface IUrunService
    {
        List<Urun> GetAll();
        Urun GetById(int id);
        void Add(Urun urun);
        void Update(Urun urun);
        void Delete(int id);
    }
}