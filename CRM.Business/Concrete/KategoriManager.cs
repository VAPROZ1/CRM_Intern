using CRM.Business.Abstract;
using CRM.DataAccess;
using CRM.Entities;

namespace CRM.Business.Concrete
{
    public class KategoriManager : IKategoriService
    {
        private readonly CrmDbContext _context;

        public KategoriManager(CrmDbContext context)
        {
            _context = context;
        }

        public List<Kategori> GetAll()
        {
            return _context.Kategoriler.ToList();
        }

        public Kategori GetById(int id)
        {
            return _context.Kategoriler.Find(id);
        }

        public void Add(Kategori kategori)
        {
            _context.Kategoriler.Add(kategori);
            _context.SaveChanges();
        }

        public void Update(Kategori kategori)
        {
            _context.Kategoriler.Update(kategori);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var kategori = GetById(id);
            if (kategori != null)
            {
                _context.Kategoriler.Remove(kategori);
                _context.SaveChanges();
            }
        }
    }
}