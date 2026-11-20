using CRM.Business.Abstract;
using CRM.DataAccess;
using CRM.Entities;

namespace CRM.Business.Concrete
{
    public class FirsatManager : IFirsatService
    {
        private readonly CrmDbContext _context;

        public FirsatManager(CrmDbContext context)
        {
            _context = context;
        }

        public List<Firsat> GetAll()
        {
            return _context.Firsatlar.ToList();
        }

        public Firsat GetById(int id)
        {
            return _context.Firsatlar.Find(id);
        }

        public void Add(Firsat firsat)
        {
            _context.Firsatlar.Add(firsat);
            _context.SaveChanges();
        }

        public void Update(Firsat firsat)
        {
            _context.Firsatlar.Update(firsat);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var firsat = GetById(id);
            if (firsat != null)
            {
                _context.Firsatlar.Remove(firsat);
                _context.SaveChanges();
            }
        }
    }
}