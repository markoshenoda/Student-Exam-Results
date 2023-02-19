using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseManger.Modules
{
    public class DataLog
    {
        public DataLog()
        {
            DateTime = DateTime.Now;
        }
        public int Id { get; set; }

        public Classes TargetClass { get; set; }

        public DateTime DateTime { get; set; }

        public User User { get; set; }

        public Action Action { get; set; }

        public MainDataBaseVerison MainDataBaseVerison { get; set; }
    }
}