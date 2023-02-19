
namespace DataBaseManger.Modules
{
    public class SubjectScore : BaseModel
    {
        public SubjectScore()
        {
            Active = true;
        }
        public int Id { get; set; }

        public uint MinimumScore { get; set; }

        public uint MaximumScore { get; set; }

        public SubjectScoreType ScoreType { get; set; }

        public Subject Subject { get; set; }

        public bool Active { get; set; }
    }
}