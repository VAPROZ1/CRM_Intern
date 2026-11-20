using CRM.Business.Abstract;
using CRM.DataAccess;
using CRM.Entities;

namespace CRM.Business.Concrete
{
    public class AktiviteManager : IAktiviteService
    {
        private readonly CrmDbContext _context;

        public AktiviteManager(CrmDbContext context)
        {
            _context = context;
        }

        public List<Aktivite> GetAll()
        {
            return _context.Aktiviteler.ToList();
        }

        public Aktivite GetById(int id)
        {
            return _context.Aktiviteler.Find(id);
        }

        public void Add(Aktivite aktivite)
        {
            _context.Aktiviteler.Add(aktivite);
            _context.SaveChanges();
        }

        public void Update(Aktivite aktivite)
        {
            _context.Aktiviteler.Update(aktivite);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var aktivite = GetById(id);
            if (aktivite != null)
            {
                _context.Aktiviteler.Remove(aktivite);
                _context.SaveChanges();
            }
        }
    }
}