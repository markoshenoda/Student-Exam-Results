using DataBaseManger.Modules;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataBaseManger.DBCommand
{
    public class UpdateCommand
    {
        private readonly SERDBConnectionSet _context;

        public UpdateCommand(SERDBConnectionSet context)
        {
            _context = context;
        }

        public void Update(User target)
        {

            using (SERDBContext context = _context.Create())
            {
                context.Users.Update(target);
                context.SaveChanges(false);
            }
        }

        public void Update(EducationalInstitution target)
        {

            using (SERDBContext context = _context.Create())
            {
                context.EducationalInstitutions.Update(target);
                context.SaveChanges(false);
            }
        }

        public void Update(Student target)
        {
            using (SERDBContext context = _context.Create())
            {
                context.Students.Update(target);
                context.SaveChanges(false);
            }
        }

        public void Update(Division target)
        {

            using (SERDBContext context = _context.Create())
            {
                context.Divisions.Update(target);
                context.SaveChanges(false);
            }

        }

        public void Update(StudentSubjectManged target)
        {

            using (SERDBContext context = _context.Create())
            {
                context.StudentSubjectMangeds.Update(target);
                context.SaveChanges(false);
            }
        }

        public void Update(StudentSubjectScore target)
        {

            using (SERDBContext context = _context.Create())
            {
                context.StudentSubjectScores.Update(target);
                context.SaveChanges(false);
            }
        }

        public void Update(Subject target)
        {

            using (SERDBContext context = _context.Create())
            {
                context.Subjects.Update(target);
                context.SaveChanges(false);
            }
        }

        public void Update(SubjectScore target)
        {

            using (SERDBContext context = _context.Create())
            {
                context.SubjectScores.Update(target);
                context.SaveChanges(false);
            }
        }

        public void Update(SubjectScoreRate target)
        {

            using (SERDBContext context = _context.Create())
            {
                context.SubjectScoreRates.Update(target);
                context.SaveChanges(false);
            }
        }

        public void Update(MainDataBaseVerison target)
        {

            using (SERDBContext context = _context.Create())
            {
                context.MainDataBaseVerison.Update(target);
                context.SaveChanges(false);
            }
        }

        public void Update(List<User> target)
        {

            using (SERDBContext context = _context.Create())
            {
                context.Users.UpdateRange(target);
                context.SaveChanges(false);
            }
        }

        public void Update(List<EducationalInstitution> target)
        {

            using (SERDBContext context = _context.Create())
            {
                context.EducationalInstitutions.UpdateRange(target);
                context.SaveChanges(false);
            }
        }

        public void Update(List<Student> target)
        {

            using (SERDBContext context = _context.Create())
            {
                context.Students.UpdateRange(target);
                context.SaveChanges(false);
            }
        }

        public void Update(List<Division> target)
        {

            using (SERDBContext context = _context.Create())
            {
                context.Divisions.UpdateRange(target);
                context.SaveChanges(false);
            }
        }

        public void Update(List<StudentSubjectManged> target)
        {

            using (SERDBContext context = _context.Create())
            {
                context.StudentSubjectMangeds.UpdateRange(target);
                context.SaveChanges(false);
            }
        }

        public void Update(List<StudentSubjectScore> target)
        {

            using (SERDBContext context = _context.Create())
            {
                context.StudentSubjectScores.UpdateRange(target);
                context.SaveChanges(false);
            }
        }

        public void Update(List<Subject> target)
        {

            using (SERDBContext context = _context.Create())
            {
                context.Subjects.UpdateRange(target);
                context.SaveChanges(false);
            }
        }

        public void Update(List<SubjectScore> target)
        {

            using (SERDBContext context = _context.Create())
            {
                context.SubjectScores.UpdateRange(target);
                context.SaveChanges(false);
            }
        }

        public void Update(List<SubjectScoreRate> target)
        {

            using (SERDBContext context = _context.Create())
            {
                context.SubjectScoreRates.UpdateRange(target);
                context.SaveChanges(false);
            }
        }

        public void Update(List<MainDataBaseVerison> target)
        {

            using (SERDBContext context = _context.Create())
            {
                context.MainDataBaseVerison.UpdateRange(target);
                context.SaveChanges(false);
            }
        }

        public async Task UpdateAsync(User target)
        {

            using (SERDBContext context = _context.Create())
            {
                context.Users.Update(target);
                await context.SaveChangesAsync(false);
            }
        }

        public async Task UpdateAsync(EducationalInstitution target)
        {

            using (SERDBContext context = _context.Create())
            {
                context.EducationalInstitutions.Update(target);
                await context.SaveChangesAsync(false);
            }
        }

        public async Task UpdateAsync(Student target)
        {

            using (SERDBContext context = _context.Create())
            {
                context.Students.Update(target);
                await context.SaveChangesAsync(false);
            }
        }

        public async Task UpdateAsync(Division target)
        {

            using (SERDBContext context = _context.Create())
            {
                context.Divisions.Update(target);
                await context.SaveChangesAsync(false);
            }
        }

        public async Task UpdateAsync(StudentSubjectManged target)
        {

            using (SERDBContext context = _context.Create())
            {
                context.StudentSubjectMangeds.Update(target);
                await context.SaveChangesAsync(false);
            }
        }

        public async Task UpdateAsync(StudentSubjectScore target)
        {

            using (SERDBContext context = _context.Create())
            {
                context.StudentSubjectScores.Update(target);
                await context.SaveChangesAsync(false);
            }
        }

        public async Task UpdateAsync(Subject target)
        {

            using (SERDBContext context = _context.Create())
            {
                context.Subjects.Update(target);
                await context.SaveChangesAsync(false);
            }
        }

        public async Task UpdateAsync(SubjectScore target)
        {

            using (SERDBContext context = _context.Create())
            {
                context.SubjectScores.Update(target);
                await context.SaveChangesAsync(false);
            }
        }

        public async Task UpdateAsync(SubjectScoreRate target)
        {

            using (SERDBContext context = _context.Create())
            {
                context.SubjectScoreRates.Update(target);
                await context.SaveChangesAsync(false);
            }
        }

        public async Task UpdateAsync(MainDataBaseVerison target)
        {

            using (SERDBContext context = _context.Create())
            {
                context.MainDataBaseVerison.Update(target);
                await context.SaveChangesAsync(false);
            }
        }

        public async Task UpdateAsync(List<User> target)
        {

            using (SERDBContext context = _context.Create())
            {
                context.Users.UpdateRange(target);
                await context.SaveChangesAsync(false);
            }
        }

        public async Task UpdateAsync(List<EducationalInstitution> target)
        {

            using (SERDBContext context = _context.Create())
            {
                context.EducationalInstitutions.UpdateRange(target);
                await context.SaveChangesAsync(false);
            }
        }

        public async Task UpdateAsync(List<Student> target)
        {

            using (SERDBContext context = _context.Create())
            {
                context.Students.UpdateRange(target);
                await context.SaveChangesAsync(false);
            }
        }

        public async Task UpdateAsync(List<Division> target)
        {

            using (SERDBContext context = _context.Create())
            {
                context.Divisions.UpdateRange(target);
                await context.SaveChangesAsync(false);
            }
        }

        public async Task UpdateAsync(List<StudentSubjectManged> target)
        {

            using (SERDBContext context = _context.Create())
            {
                context.StudentSubjectMangeds.UpdateRange(target);
                await context.SaveChangesAsync(false);
            }
        }

        public async Task UpdateAsync(List<StudentSubjectScore> target)
        {

            using (SERDBContext context = _context.Create())
            {
                context.StudentSubjectScores.UpdateRange(target);
                await context.SaveChangesAsync(false);
            }
        }

        public async Task UpdateAsync(List<Subject> target)
        {

            using (SERDBContext context = _context.Create())
            {
                context.Subjects.UpdateRange(target);
                await context.SaveChangesAsync(false);
            }
        }

        public async Task UpdateAsync(List<SubjectScore> target)
        {

            using (SERDBContext context = _context.Create())
            {
                context.SubjectScores.UpdateRange(target);
                await context.SaveChangesAsync(false);
            }
        }

        public async Task UpdateAsync(List<SubjectScoreRate> target)
        {

            using (SERDBContext context = _context.Create())
            {
                context.SubjectScoreRates.UpdateRange(target);
                await context.SaveChangesAsync(false);
            }
        }

        public async Task UpdateAsync(List<MainDataBaseVerison> target)
        {
            using (SERDBContext context = _context.Create())
            {
                context.MainDataBaseVerison.UpdateRange(target);
                await context.SaveChangesAsync(false);
            }
        }
    }
}