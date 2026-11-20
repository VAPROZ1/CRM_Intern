using CRM.Entities;

namespace CRM.Business.Abstract
{
    public interface ITeklifKalemiService
    {
        List<TeklifKalemi> GetAll();
        TeklifKalemi GetById(int id);
        void Add(TeklifKalemi teklifKalemi);
        void Update(TeklifKalemi teklifKalemi);
        void Delete(int id);
    }
}