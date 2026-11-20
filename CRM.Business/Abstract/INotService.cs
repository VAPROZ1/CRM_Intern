using CRM.Entities;

namespace CRM.Business.Abstract
{
    public interface INotService
    {
        List<Not> GetAll();
        Not GetById(int id);
        void Add(Not not);
        void Update(Not not);
        void Delete(int id);
    }
}