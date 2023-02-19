using System;

namespace DataBaseManger.Modules
{
    public class StudentSubjectManged : BaseModel
    {
        public StudentSubjectManged()
        {
            Active = true;
        }
        public int Id { get; set; }

        public User Add { get; set; }

        public User AddSupport { get; set; }

        public DateTime AddDate { get; set; }

        public User Conferm { get; set; }

        public User ConfermSupport { get; set; }

        public DateTime ConferdDate { get; set; }

        public SubjectScoreType SubjectScoreType { get; set; }

        public bool Active { get; set; }
    }
}