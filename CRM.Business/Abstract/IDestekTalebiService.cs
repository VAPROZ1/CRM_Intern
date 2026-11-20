using CRM.Entities;

namespace CRM.Business.Abstract
{
    public interface IDestekTalebiService
    {
        List<DestekTalebi> GetAll();
        DestekTalebi GetById(int id);
        void Add(DestekTalebi destekTalebi);
        void Update(DestekTalebi destekTalebi);
        void Delete(int id);
    }
}