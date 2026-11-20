using CRM.Entities;

namespace CRM.Business.Abstract
{
    public interface IFirsatService
    {
        List<Firsat> GetAll();
        Firsat GetById(int id);
        void Add(Firsat firsat);
        void Update(Firsat firsat);
        void Delete(int id);
    }
}