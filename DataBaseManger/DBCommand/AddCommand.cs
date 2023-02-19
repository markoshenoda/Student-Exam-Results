using DataBaseManger.Modules;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataBaseManger.DBCommand
{
    public class AddCommand 
    {
        private readonly SERDBConnectionSet _context;

        public AddCommand(SERDBConnectionSet context)
        {
            _context = context;
        }

        public void Add(User target)
        {
            using (SERDBContext context = _context.Create())
            {
                context.AttachRange(target.InstitutionDivisions);
                context.Users.Add(target);
                context.SaveChanges();
            }
        }

        public void Add(EducationalInstitution target)
        {
            using (SERDBContext context = _context.Create())
            {
                context.AttachRange(target.InstitutionDivisions);
                context.EducationalInstitutions.Add(target);
                context.SaveChanges();
            }
        }

        public void Add(Student target)
        {
            using (SERDBContext context = _context.Create())
            {
                context.Students.Add(target);
                context.SaveChanges(false);
            }
        }

        public void Add(Division target)
        {
            using SERDBContext context = _context.Create();
            _ = context.Attach(target.MainDivision.Id);
            _ = context.Divisions.Add(target);
            _ = context.SaveChanges();
        }

        public void Add(StudentSubjectManged target)
        {

            using (SERDBContext context = _context.Create())
            {
                context.StudentSubjectMangeds.Add(target);
                context.SaveChanges(false);
            }
        }

        public void Add(StudentSubjectScore target)
        {

            using (SERDBContext context = _context.Create())
            {
                context.StudentSubjectScores.Add(target);
                context.SaveChanges(false);
            }
        }

        public void Add(Subject target)
        {

            using (SERDBContext context = _context.Create())
            {
                context.Subjects.Add(target);
                context.SaveChanges();
            }

        }

        public void Add(SubjectScore target)
        {

            using (SERDBContext context = _context.Create())
            {
                context.SubjectScores.Add(target);
                context.SaveChanges(false);
            }
        }

        public void Add(SubjectScoreRate target)
        {

            using (SERDBContext context = _context.Create())
            {
                context.SubjectScoreRates.Add(target);
                context.SaveChanges(false);
            }
        }

        public void Add(MainDataBaseVerison target)
        {

            using (SERDBContext context = _context.Create())
            {
                context.MainDataBaseVerison.Add(target);
                context.SaveChanges(false);
            }
        }

        public void Add(InstitutionDivision target)
        {

            using (SERDBContext context = _context.Create())
            {
                context.InstitutionDivisions.Add(target);
                context.SaveChanges(false);
            }
        }

        public void Add(List<User> target)
        {

            using (SERDBContext context = _context.Create())
            {
                foreach (User item in target)
                    context.AttachRange(item.InstitutionDivisions);
                context.Users.AddRange(target);
                context.SaveChanges();
            }
        }

        public void Add(List<EducationalInstitution> target)
        {

            using (SERDBContext context = _context.Create())
            {
                List<List<InstitutionDivision>> x = new List<List<InstitutionDivision>>();
                foreach (EducationalInstitution item in target)
                {
                    x.Add(item.InstitutionDivisions);
                    item.InstitutionDivisions = null;
                }
                context.EducationalInstitutions.AddRange(target);
                context.SaveChanges();
                for (int i = 0; i < target.Count; i++)
                {
                    foreach (InstitutionDivision item in x[i])
                        item.EducationalInstitution = target[i];
                    target[i].InstitutionDivisions = x[i];
                }
                context.EducationalInstitutions.UpdateRange(target);
                context.SaveChanges();
            }
        }

        public void Add(List<Student> target)
        {

            using (SERDBContext context = _context.Create())
            {
                context.Students.AddRange(target);
                context.SaveChanges(false);
            }
        }

        public void Add(List<Division> target)
        {

            using (SERDBContext context = _context.Create())
            {
                context.Divisions.AddRange(target);
                context.SaveChanges(false);
            }
        }

        public void Add(List<StudentSubjectManged> target)
        {

            using (SERDBContext context = _context.Create())
            {
                context.StudentSubjectMangeds.AddRange(target);
                context.SaveChanges(false);
            }
        }

        public void Add(List<StudentSubjectScore> target)
        {

            using (SERDBContext context = _context.Create())
            {
                context.StudentSubjectScores.AddRange(target);
                context.SaveChanges(false);
            }
        }

        public void Add(List<Subject> target)
        {

            using (SERDBContext context = _context.Create())
            {
                context.Subjects.AddRange(target);
                context.SaveChanges(false);
            }

        }

        public void Add(List<SubjectScore> target)
        {

            using (SERDBContext context = _context.Create())
            {
                context.SubjectScores.AddRange(target);
                context.SaveChanges(false);
            }

        }

        public void Add(List<SubjectScoreRate> target)
        {

            using (SERDBContext context = _context.Create())
            {
                context.SubjectScoreRates.AddRange(target);
                context.SaveChanges(false);
            }
        }

        public void Add(List<MainDataBaseVerison> target)
        {

            using (SERDBContext context = _context.Create())
            {
                context.MainDataBaseVerison.AddRange(target);
                context.SaveChanges(false);
            }
        }

        public void Add(List<InstitutionDivision> target)
        {

            using (SERDBContext context = _context.Create())
            {
                context.InstitutionDivisions.AddRange(target);
                context.SaveChanges(false);
            }
        }

        public async Task AddAsync(User target)
        {

            using (SERDBContext context = _context.Create())
            {
                context.AttachRange(target.InstitutionDivisions);
                context.Users.Add(target);
                await context.SaveChangesAsync(false);
            }
        }

        public async Task AddAsync(EducationalInstitution target)
        {

            using (SERDBContext context = _context.Create())
            {
                context.EducationalInstitutions.Add(target);
                await context.SaveChangesAsync(false);
            }
        }

        public async Task AddAsync(Student target)
        {

            using (SERDBContext context = _context.Create())
            {
                context.Students.Add(target);
                await context.SaveChangesAsync(false);
            }
        }

        public async Task AddAsync(Division target)
        {

            using (SERDBContext context = _context.Create())
            {
                context.Divisions.Add(target);
                await context.SaveChangesAsync(false);
            }
        }

        public async Task AddAsync(StudentSubjectManged target)
        {

            using (SERDBContext context = _context.Create())
            {
                context.StudentSubjectMangeds.Add(target);
                await context.SaveChangesAsync(false);
            }
        }

        public async Task AddAsync(StudentSubjectScore target)
        {

            using (SERDBContext context = _context.Create())
            {
                context.StudentSubjectScores.Add(target);
                await context.SaveChangesAsync(false);
            }
        }

        public async Task AddAsync(Subject target)
        {

            using (SERDBContext context = _context.Create())
            {
                context.Subjects.Add(target);
                await context.SaveChangesAsync(false);
            }
        }

        public async Task AddAsync(SubjectScore target)
        {

            using (SERDBContext context = _context.Create())
            {
                context.SubjectScores.Add(target);
                await context.SaveChangesAsync(false);
            }
        }

        public async Task AddAsync(SubjectScoreRate target)
        {

            using (SERDBContext context = _context.Create())
            {
                context.SubjectScoreRates.Add(target);
                await context.SaveChangesAsync(false);
            }
        }

        public async Task AddAsync(MainDataBaseVerison target)
        {

            using (SERDBContext context = _context.Create())
            {
                context.MainDataBaseVerison.Add(target);
                await context.SaveChangesAsync(false);
            }
        }

        public async Task AddAsync(InstitutionDivision target)
        {

            using (SERDBContext context = _context.Create())
            {
                context.InstitutionDivisions.Add(target);
                await context.SaveChangesAsync(false);
            }
        }

        public async Task AddAsync(List<User> target)
        {

            using (SERDBContext context = _context.Create())
            {
                foreach (User item in target)
                    context.AttachRange(item.InstitutionDivisions);
                context.Users.AddRange(target);
                await context.SaveChangesAsync(false);
            }
        }

        public async Task AddAsync(List<EducationalInstitution> target)
        {

            using (SERDBContext context = _context.Create())
            {
                context.EducationalInstitutions.AddRange(target);
                await context.SaveChangesAsync(false);
            }
        }

        public async Task AddAsync(List<Student> target)
        {

            using (SERDBContext context = _context.Create())
            {
                context.Students.AddRange(target);
                await context.SaveChangesAsync(false);
            }
        }

        public async Task AddAsync(List<Division> target)
        {

            using (SERDBContext context = _context.Create())
            {
                context.Divisions.AddRange(target);
                await context.SaveChangesAsync(false);
            }
        }

        public async Task AddAsync(List<StudentSubjectManged> target)
        {

            using (SERDBContext context = _context.Create())
            {
                context.StudentSubjectMangeds.AddRange(target);
                await context.SaveChangesAsync(false);
            }
        }

        public async Task AddAsync(List<StudentSubjectScore> target)
        {

            using (SERDBContext context = _context.Create())
            {
                context.StudentSubjectScores.AddRange(target);
                await context.SaveChangesAsync(false);
            }
        }

        public async Task AddAsync(List<Subject> target)
        {

            using (SERDBContext context = _context.Create())
            {
                context.Subjects.AddRange(target);
                await context.SaveChangesAsync(false);
            }
        }

        public async Task AddAsync(List<SubjectScore> target)
        {

            using (SERDBContext context = _context.Create())
            {
                context.SubjectScores.AddRange(target);
                await context.SaveChangesAsync(false);
            }
        }

        public async Task AddAsync(List<SubjectScoreRate> target)
        {

            using (SERDBContext context = _context.Create())
            {
                context.SubjectScoreRates.AddRange(target);
                await context.SaveChangesAsync(false);
            }
        }

        public async Task AddAsync(List<MainDataBaseVerison> target)
        {

            using (SERDBContext context = _context.Create())
            {
                context.MainDataBaseVerison.AddRange(target);
                await context.SaveChangesAsync(false);
            }
        }

        public async Task AddAsync(List<InstitutionDivision> target)
        {

            using (SERDBContext context = _context.Create())
            {
                context.InstitutionDivisions.AddRange(target);
                await context.SaveChangesAsync(false);
            }
        }
    }
}