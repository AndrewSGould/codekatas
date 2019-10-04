using Microsoft.EntityFrameworkCore;
using SharpKatas.Models;

namespace SharpKatas.Data
{
    public class CarContext : DbContext
    {
        public CarContext (DbContextOptions<CarContext> options)
            : base(options)
        {
        }

        public DbSet<Car> Car { get; set; }
    }
}
