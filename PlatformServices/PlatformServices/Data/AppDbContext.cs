using Microsoft.EntityFrameworkCore;

namespace PlatformServices.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt):base(opt)
        {

        }

    }
}
