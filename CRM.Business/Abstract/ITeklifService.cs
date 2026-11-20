using CRM.Entities;

namespace CRM.Business.Abstract
{
    public interface ITeklifService
    {
        List<Teklif> GetAll();
        Teklif GetById(int id);
        void Add(Teklif teklif);
        void Update(Teklif teklif);
        void Delete(int id);
    }
}