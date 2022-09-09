using PlatformServices.Models;

namespace PlatformServices.Data
{
    public class PlatformRepo : IPlatformRepo
    {
        private readonly AppDbContext _context;

        public PlatformRepo(AppDbContext context)
        {
            _context = context;

        }
        public void CreatePlatform(Platform plat)
        {
            if(plat == null)
            {
                throw new ArgumentNullException(nameof(plat));
            }
            _context.Platfroms.Add(plat);
        }

        public Platform GetPlatformById(int id)
        {
            return _context.Platfroms.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Platform> GetAllPlatforms()
        {
            return _context.Platfroms.ToList();
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
