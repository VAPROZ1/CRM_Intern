using CRM.Business.Abstract;
using CRM.DataAccess;
using CRM.Entities;

namespace CRM.Business.Concrete
{
    public class FirmaManager : IFirmaService
    {
        private readonly CrmDbContext _context;

        public FirmaManager(CrmDbContext context)
        {
            _context = context;
        }

        public List<Firma> GetAll()
        {
            return _context.Firmalar.ToList();
        }

        public Firma GetById(int id)
        {
            return _context.Firmalar.Find(id);
        }

        public void Add(Firma firma)
        {
            _context.Firmalar.Add(firma);
            _context.SaveChanges();
        }

        public void Update(Firma firma)
        {
            _context.Firmalar.Update(firma);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var firma = GetById(id);
            if (firma != null)
            {
                _context.Firmalar.Remove(firma);
                _context.SaveChanges();
            }
        }
    }
}