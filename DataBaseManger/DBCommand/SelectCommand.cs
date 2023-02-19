using DataBaseManger.Modules;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace DataBaseManger.DBCommand
{
    public class SelectCommand
    {
        private readonly SERDBConnectionSet _context;

        public SelectCommand(SERDBConnectionSet context)
        {
            _context = context;
        }

        public User Select(User target)
        {
            using (SERDBContext context = _context.Create())
            {
                return context.Users.FirstOrDefault(d => d.Id == target.Id);
            }
        }

        public EducationalInstitution Select(EducationalInstitution target)
        {
            using (SERDBContext context = _context.Create())
            {
                return context.EducationalInstitutions.FirstOrDefault(d => d.Id == target.Id);
            }
        }

        public Student Select(Student target)
        {
            using (SERDBContext context = _context.Create())
            {
                return context.Students.FirstOrDefault(d => d.Id == target.Id);
            }
        }

        public Division Select(Division target)
        {
            using (SERDBContext context = _context.Create())
            {
                return context.Divisions.FirstOrDefault(d => d.Id == target.Id);
            }
        }

        public StudentSubjectManged Select(StudentSubjectManged target)
        {
            using (SERDBContext context = _context.Create())
            {
                return context.StudentSubjectMangeds.FirstOrDefault(d => d.Id == target.Id);
            }
        }

        public StudentSubjectScore Select(StudentSubjectScore target)
        {
            using (SERDBContext context = _context.Create())
            {
                return context.StudentSubjectScores.FirstOrDefault(d => d.Id == target.Id);
            }
        }

        public Subject Select(Subject target)
        {
            using (SERDBContext context = _context.Create())
            {
                return context.Subjects.FirstOrDefault(d => d.Id == target.Id);
            }
        }

        public SubjectScore Select(SubjectScore target)
        {
            using (SERDBContext context = _context.Create())
            {
                return context.SubjectScores.FirstOrDefault(d => d.Id == target.Id);
            }
        }

        public SubjectScoreRate Select(SubjectScoreRate target)
        {
            using (SERDBContext context = _context.Create())
            {
                return context.SubjectScoreRates.FirstOrDefault(d => d.Id == target.Id);
            }
        }

        public MainDataBaseVerison Select(MainDataBaseVerison target)
        {
            using (SERDBContext context = _context.Create())
            {
                return context.MainDataBaseVerison.FirstOrDefault(d => d.Id == target.Id);
            }
        }

        public async Task<User> SelectAsync(User target)
        {
            using (SERDBContext context = _context.Create())
            {
                return await context.Users.FirstOrDefaultAsync(d => d.Id == target.Id);
            }
        }

        public async Task<EducationalInstitution> SelectAsync(EducationalInstitution target)
        {
            using (SERDBContext context = _context.Create())
            {
                return await context.EducationalInstitutions.FirstOrDefaultAsync(d => d.Id == target.Id);
            }
        }

        public async Task<Student> SelectAsync(Student target)
        {
            using (SERDBContext context = _context.Create())
            {
                return await context.Students.FirstOrDefaultAsync(d => d.Id == target.Id);
            }
        }

        public async Task<Division> SelectAsync(Division target)
        {
            using (SERDBContext context = _context.Create())
            {
                return await context.Divisions.FirstOrDefaultAsync(d => d.Id == target.Id);
            }
        }

        public async Task<StudentSubjectManged> SelectAsync(StudentSubjectManged target)
        {
            using (SERDBContext context = _context.Create())
            {
                return await context.StudentSubjectMangeds.FirstOrDefaultAsync(d => d.Id == target.Id);
            }
        }

        public async Task<StudentSubjectScore> SelectAsync(StudentSubjectScore target)
        {
            using (SERDBContext context = _context.Create())
            {
                return await context.StudentSubjectScores.FirstOrDefaultAsync(d => d.Id == target.Id);
            }
        }

        public async Task<Subject> SelectAsync(Subject target)
        {
            using (SERDBContext context = _context.Create())
            {
                return await context.Subjects.FirstOrDefaultAsync(d => d.Id == target.Id);
            }
        }

        public async Task<SubjectScore> SelectAsync(SubjectScore target)
        {
            using (SERDBContext context = _context.Create())
            {
                return await context.SubjectScores.FirstOrDefaultAsync(d => d.Id == target.Id);
            }
        }

        public async Task<SubjectScoreRate> SelectAsync(SubjectScoreRate target)
        {
            using (SERDBContext context = _context.Create())
            {
                return await context.SubjectScoreRates.FirstOrDefaultAsync(d => d.Id == target.Id);
            }
        }

        public async Task<MainDataBaseVerison> SelectAsync(MainDataBaseVerison target)
        {
            using (SERDBContext context = _context.Create())
            {
                return await context.MainDataBaseVerison.FirstOrDefaultAsync(d => d.Id == target.Id);
            }
        }
    }
}