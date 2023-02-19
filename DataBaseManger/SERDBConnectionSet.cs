using Microsoft.EntityFrameworkCore;

namespace DataBaseManger
{
   public class SERDBConnectionSet
    {
        private readonly DbContextOptions _options;

        public SERDBConnectionSet(DbContextOptions options)
        {
            _options = options;
        }

        public SERDBContext Create()
        {
            return new SERDBContext(_options);
        }
    }
}