using DataBaseManger;
using DataBaseManger.Modules;
using Microsoft.EntityFrameworkCore;
using System.Windows;

namespace SER.Run
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static SERDBConnectionSet localDB;

        public static SERDBConnectionSet mainDB;

        public static User LoginUser;
        public App()
        {
            localDB = new SERDBConnectionSet(
                new DbContextOptionsBuilder().UseSqlite("Data Source=LocalDb.dll").EnableSensitiveDataLogging().UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking).Options);

            mainDB = new SERDBConnectionSet(
                new DbContextOptionsBuilder().UseSqlite("Data Source=MainDB.dll").UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking).Options);
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            using (SERDBContext context = localDB.Create())
            {
                context.Database.Migrate();
            }

            using (SERDBContext context = mainDB.Create())
            {
                context.Database.Migrate();
            }

            base.OnStartup(e);

            MainWindow = new StarupWindows();
            MainWindow.Show();
        }
    }
}