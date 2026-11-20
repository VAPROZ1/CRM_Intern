using CRM.Business.Abstract;
using CRM.DataAccess;
using CRM.Entities;

namespace CRM.Business.Concrete
{
    public class TeklifManager : ITeklifService
    {
        private readonly CrmDbContext _context;

        public TeklifManager(CrmDbContext context)
        {
            _context = context;
        }

        public List<Teklif> GetAll()
        {
            return _context.Teklifler.ToList();
        }

        public Teklif GetById(int id)
        {
            return _context.Teklifler.Find(id);
        }

        public void Add(Teklif teklif)
        {
            _context.Teklifler.Add(teklif);
            _context.SaveChanges();
        }

        public void Update(Teklif teklif)
        {
            _context.Teklifler.Update(teklif);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var teklif = GetById(id);
            if (teklif != null)
            {
                _context.Teklifler.Remove(teklif);
                _context.SaveChanges();
            }
        }
    }
}