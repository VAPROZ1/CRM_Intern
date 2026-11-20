using CRM.Business.Abstract;
using CRM.DataAccess;
using CRM.Entities;

namespace CRM.Business.Concrete
{
    public class NotManager : INotService
    {
        private readonly CrmDbContext _context;

        public NotManager(CrmDbContext context)
        {
            _context = context;
        }

        public List<Not> GetAll()
        {
            return _context.Notlar.ToList();
        }

        public Not GetById(int id)
        {
            return _context.Notlar.Find(id);
        }

        public void Add(Not not)
        {
            _context.Notlar.Add(not);
            _context.SaveChanges();
        }

        public void Update(Not not)
        {
            _context.Notlar.Update(not);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var notEntity = GetById(id);
            if (notEntity != null)
            {
                _context.Notlar.Remove(notEntity);
                _context.SaveChanges();
            }
        }
    }
}