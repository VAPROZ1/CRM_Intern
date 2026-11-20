using CRM.Business.Abstract;
using CRM.DataAccess;
using CRM.Entities;

namespace CRM.Business.Concrete
{
    public class UrunManager : IUrunService
    {
        private readonly CrmDbContext _context;

        public UrunManager(CrmDbContext context)
        {
            _context = context;
        }

        public List<Urun> GetAll()
        {
            return _context.Urunler.ToList();
        }

        public Urun GetById(int id)
        {
            return _context.Urunler.Find(id);
        }

        public void Add(Urun urun)
        {
            _context.Urunler.Add(urun);
            _context.SaveChanges();
        }

        public void Update(Urun urun)
        {
            _context.Urunler.Update(urun);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var urun = GetById(id);
            if (urun != null)
            {
                _context.Urunler.Remove(urun);
                _context.SaveChanges();
            }
        }
    }
}