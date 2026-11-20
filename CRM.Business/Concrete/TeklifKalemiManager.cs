using CRM.Business.Abstract;
using CRM.DataAccess;
using CRM.Entities;

namespace CRM.Business.Concrete
{
    public class TeklifKalemiManager : ITeklifKalemiService
    {
        private readonly CrmDbContext _context;

        public TeklifKalemiManager(CrmDbContext context)
        {
            _context = context;
        }

        public List<TeklifKalemi> GetAll()
        {
            return _context.TeklifKalemleri.ToList();
        }

        public TeklifKalemi GetById(int id)
        {
            return _context.TeklifKalemleri.Find(id);
        }

        public void Add(TeklifKalemi teklifKalemi)
        {
            _context.TeklifKalemleri.Add(teklifKalemi);
            _context.SaveChanges();
        }

        public void Update(TeklifKalemi teklifKalemi)
        {
            _context.TeklifKalemleri.Update(teklifKalemi);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var teklifKalemi = GetById(id);
            if (teklifKalemi != null)
            {
                _context.TeklifKalemleri.Remove(teklifKalemi);
                _context.SaveChanges();
            }
        }
    }
}