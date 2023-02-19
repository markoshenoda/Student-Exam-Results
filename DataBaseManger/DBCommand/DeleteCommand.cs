using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseManger.DBCommand
{
    public class DeleteCommand
    {
        private readonly SERDBConnectionSet _context;

        public DeleteCommand(SERDBConnectionSet context)
        {
            _context = context;
        }
    }
}