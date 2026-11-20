using CRM.Business.Abstract;
using CRM.DataAccess;
using CRM.Entities;

namespace CRM.Business.Concrete
{
    public class DestekTalebiManager : IDestekTalebiService
    {
        private readonly CrmDbContext _context;

        public DestekTalebiManager(CrmDbContext context)
        {
            _context = context;
        }

        public List<DestekTalebi> GetAll()
        {
            return _context.DestekTalepleri.ToList();
        }

        public DestekTalebi GetById(int id)
        {
            return _context.DestekTalepleri.Find(id);
        }

        public void Add(DestekTalebi destekTalebi)
        {
            _context.DestekTalepleri.Add(destekTalebi);
            _context.SaveChanges();
        }

        public void Update(DestekTalebi destekTalebi)
        {
            _context.DestekTalepleri.Update(destekTalebi);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var destekTalebi = GetById(id);
            if (destekTalebi != null)
            {
                _context.DestekTalepleri.Remove(destekTalebi);
                _context.SaveChanges();
            }
        }
    }
}