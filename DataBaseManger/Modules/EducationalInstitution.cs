using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseManger.Modules
{
    public class EducationalInstitution : BaseModel
    {
        public EducationalInstitution()
        {
            Active = true;
            InstitutionDivisions = new();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public bool Active { get; set; }

        public List<InstitutionDivision> InstitutionDivisions { get; set; }
    }
}