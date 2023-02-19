
namespace DataBaseManger.Modules
{
    public class StudentSubjectScore : BaseModel
    {
        public StudentSubjectScore()
        {
            Active = true;
        }
        public int Id { get; set; }

        public uint Score { get; set; }

        public SubjectScoreType ScoreType { get; set; }

        public Subject Subject { get; set; }

        public Student Student { get; set; }

        public bool Confirmed { get; set; }

        public StudentSubjectStat StudentSubjectStat { get; set; }

        public StudentSubjectManged StudentSubjectManged { get; set; }

        public bool Active { get; set; }
    }
}