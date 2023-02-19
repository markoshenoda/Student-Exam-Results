using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace DataBaseManger
{
    public class StartDb : IDesignTimeDbContextFactory<SERDBContext>
    {
        public SERDBContext CreateDbContext(string[] args = null)
        {
            return new SERDBContext(new DbContextOptionsBuilder().EnableSensitiveDataLogging().UseSqlite("Data Source=MainDB.dll").UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking).Options);
        }
    }
}