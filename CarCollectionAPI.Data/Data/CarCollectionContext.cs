namespace CarCollectionAPI.Data.Data
{
    using CarCollectionAPI.Data.Models;
    using Microsoft.EntityFrameworkCore;

    public class CarCollectionContext : DbContext
    {
        public CarCollectionContext(DbContextOptions<CarCollectionContext> options)
            : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Collection> Collections { get; set; }
    }
}
