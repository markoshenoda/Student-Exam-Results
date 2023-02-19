using System.Collections.Generic;

namespace DataBaseManger.Modules
{
    public class InstitutionDivision : BaseModel
    {
        public InstitutionDivision()
        {
            Active = true;
            Users = new();
            Students = new();
        }
        public int Id { get; set; }

        public Division Division { get; set; }

        public EducationalInstitution EducationalInstitution { get; set; }

        public List<User> Users { get; set; }

        public List<Student> Students { get; set; }

        public bool Active { get;set; }
    }
}