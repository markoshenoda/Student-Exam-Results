using System.Collections.Generic;

namespace DataBaseManger.Modules
{
    public class Division : BaseModel
    {
        public Division()
        {
            Subjects = new();
            InstitutionDivisions = new();
            Active = true;
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public Division MainDivision { get; set; }

        public List<Division> SubDivisions { get; set; }

        public bool Active { get; set; }

        public List<Subject> Subjects { get; set; }

        public List<InstitutionDivision> InstitutionDivisions { get; set; }
    }
}