using System.Collections.Generic;

namespace DataBaseManger.Modules
{
    public class Student : BaseModel
    {
        public Student()
        {
            Active = true;
            Scores = new();
            Stat = StudentStat.New;
        }
        public int Id { get; set; }

        public uint Code { get; set; }

        public string Name { get; set; }

        public uint Year { get; set; }

        public InstitutionDivision InstitutionDivision { get; set; }

        public StudentStat Stat { get; set; }

        public List<StudentSubjectScore> Scores { get; set; }

        public bool Active { get; set; }
    }
}