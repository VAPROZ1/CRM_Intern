using CRM.Business.Abstract;
using CRM.DataAccess;
using CRM.Entities;

namespace CRM.Business.Concrete
{
    public class MusteriManager : IMusteriService
    {
        private readonly CrmDbContext _context;

        // Veritabanı kapısını (DbContext) buraya enjekte ediyoruz (Dependency Injection)
        public MusteriManager(CrmDbContext context)
        {
            _context = context;
        }

        public List<Musteri> GetAll()
        {
            // Veritabanındaki Musteriler tablosuna git, hepsini liste olarak getir
            return _context.Musteriler.ToList();
        }

        public Musteri GetById(int id)
        {
            return _context.Musteriler.Find(id);
        }

        public void Add(Musteri musteri)
        {
            _context.Musteriler.Add(musteri);
            _context.SaveChanges(); // Değişiklikleri veritabanına kalıcı olarak kaydet
        }

        public void Update(Musteri musteri)
        {
            _context.Musteriler.Update(musteri);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var musteri = GetById(id);
            if (musteri != null)
            {
                _context.Musteriler.Remove(musteri);
                _context.SaveChanges();
            }
        }
    }
}