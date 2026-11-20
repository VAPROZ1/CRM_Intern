using CRM.Entities;

namespace CRM.Business.Abstract
{
    public interface IAktiviteService
    {
        List<Aktivite> GetAll();
        Aktivite GetById(int id);
        void Add(Aktivite aktivite);
        void Update(Aktivite aktivite);
        void Delete(int id);
    }
}