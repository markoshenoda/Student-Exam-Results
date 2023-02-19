using System.Collections.Generic;

namespace DataBaseManger.Modules
{
   public class MainDataBaseVerison : BaseModel
    {
        public MainDataBaseVerison()
        {
            Logs = new();
            Active = true;
        }
        public int Id { get; set; }

        public int Verison { get; set; }

        public List<DataLog> Logs { get; set; }

        public bool Active { get; set; }
    }
}