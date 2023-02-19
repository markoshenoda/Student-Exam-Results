using System.Collections.Generic;

namespace DataBaseManger.Modules
{
    public class Subject : BaseModel
    {
        public Subject()
        {
            Active = true;
            SubjectScores = new();
            Divisions = new();
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public List<SubjectScore> SubjectScores { get; set; }

        public List<Division> Divisions { get; set; }

        public SubjectScoreRate SubjectScoreRate { get; set; }

        public bool Active { get; set; }
    }
}