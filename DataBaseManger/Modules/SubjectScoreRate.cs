using System.Collections.Generic;

namespace DataBaseManger.Modules
{
    public class SubjectScoreRate : BaseModel
    {
        public SubjectScoreRate()
        {
            Active = true;
            Subjects = new();
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public int PassMin { get; set; }

        public int Good { get; set; }

        public int VeryGood { get; set; }

        public int Excellent { get; set; }

        public List<Subject> Subjects { get; set; }

        public bool Active { get; set; }
    }
}