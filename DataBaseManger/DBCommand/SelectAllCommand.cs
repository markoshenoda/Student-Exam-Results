using DataBaseManger.Modules;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataBaseManger.DBCommand
{
    public class SelectAllCommand<T> where T : class
    {
        private readonly SERDBConnectionSet _context;

        public SelectAllCommand(SERDBConnectionSet context)
        {
            _context = context;
        }

        public List<BaseModel> SelectAll()
        {
            using (SERDBContext context = _context.Create())
            {
                if (typeof(T) == typeof(Division))
                    return context.Divisions.
                        Include(x => x.Subjects).
                        ThenInclude(x => x.SubjectScores).
                        Include(x => x.Subjects).ThenInclude(x => x.SubjectScoreRate)
                        .ToList<BaseModel>();

                if (typeof(T) == typeof(EducationalInstitution))
                    return context.EducationalInstitutions.Include(x => x.InstitutionDivisions).ThenInclude(x => x.Division).ToList<BaseModel>();

                if (typeof(T) == typeof(InstitutionDivision))
                    return context.InstitutionDivisions.ToList<BaseModel>();

                if (typeof(T) == typeof(Student))
                    return context.Students.ToList<BaseModel>();

                if (typeof(T) == typeof(StudentSubjectScore))
                    return context.StudentSubjectScores.ToList<BaseModel>();

                if (typeof(T) == typeof(StudentSubjectManged))
                    return context.StudentSubjectMangeds.ToList<BaseModel>();

                if (typeof(T) == typeof(Subject))
                    return context.Subjects.ToList<BaseModel>();

                if (typeof(T) == typeof(SubjectScore))
                    return context.SubjectScores.ToList<BaseModel>();

                if (typeof(T) == typeof(SubjectScoreRate))
                    return context.SubjectScoreRates.ToList<BaseModel>();

                if (typeof(T) == typeof(User))
                    return context.Users.ToList<BaseModel>();
            }
            return null;
        }

        public List<BaseModel> SelectAll(bool active)
        {
            using (SERDBContext context = _context.Create())
            {
                if (typeof(T) == typeof(Division))
                    return context.Divisions.Where(x => x.Active == active).Include(x => x.MainDivision).
                        Include(x => x.SubDivisions).
                        Include(x => x.Subjects).
                        ThenInclude(x => x.SubjectScores).
                        Include(x => x.Subjects).ThenInclude(x => x.SubjectScoreRate)
                        .ToList<BaseModel>();

                if (typeof(T) == typeof(EducationalInstitution))
                    return context.EducationalInstitutions.Where(x => x.Active == active)
                        .Include(x => x.InstitutionDivisions)
                        .ThenInclude(x => x.Division).ToList<BaseModel>();

                if (typeof(T) == typeof(InstitutionDivision))
                    return context.InstitutionDivisions.Where(x => x.Active == active).ToList<BaseModel>();

                if (typeof(T) == typeof(Student))
                    return context.Students.Where(x => x.Active == active).ToList<BaseModel>();

                if (typeof(T) == typeof(StudentSubjectScore))
                    return context.StudentSubjectScores.Where(x => x.Active == active).ToList<BaseModel>();

                if (typeof(T) == typeof(StudentSubjectManged))
                    return context.StudentSubjectMangeds.Where(x => x.Active == active).ToList<BaseModel>();

                if (typeof(T) == typeof(Subject))
                    return context.Subjects.Where(x => x.Active == active).ToList<BaseModel>();

                if (typeof(T) == typeof(SubjectScore))
                    return context.SubjectScores.Where(x => x.Active == active).ToList<BaseModel>();

                if (typeof(T) == typeof(SubjectScoreRate))
                    return context.SubjectScoreRates.Where(x => x.Active == active).ToList<BaseModel>();

                if (typeof(T) == typeof(User))
                    return context.Users.Where(x => x.Active == active).ToList<BaseModel>();
            }
            return null;
        }

        public List<BaseModel> SelectAll(BaseModel target)
        {
            using (SERDBContext context = _context.Create())
            {
                if (typeof(T) == typeof(Division))
                    return context.Divisions.Where(x => x.Active == ((Division)target).Active && x.MainDivision == null).Include(x => x.MainDivision).
                        Include(x => x.SubDivisions).
                        Include(x => x.Subjects).
                        ThenInclude(x => x.SubjectScores).
                        Include(x => x.Subjects).ThenInclude(x => x.SubjectScoreRate)
                        .ToList<BaseModel>();

                if (typeof(T) == typeof(EducationalInstitution))
                    return context.EducationalInstitutions.Where(x => x == target).ToList<BaseModel>();

                if (typeof(T) == typeof(InstitutionDivision))
                    return context.InstitutionDivisions.Where(x => x == target).ToList<BaseModel>();

                if (typeof(T) == typeof(Student))
                    return context.Students.Where(x => x == target).ToList<BaseModel>();

                if (typeof(T) == typeof(StudentSubjectScore))
                    return context.StudentSubjectScores.Where(x => x == target).ToList<BaseModel>();

                if (typeof(T) == typeof(StudentSubjectManged))
                    return context.StudentSubjectMangeds.Where(x => x == target).ToList<BaseModel>();

                if (typeof(T) == typeof(Subject))
                    return context.Subjects.Where(x => x == target).ToList<BaseModel>();

                if (typeof(T) == typeof(SubjectScore))
                    return context.SubjectScores.Where(x => x == target).ToList<BaseModel>();

                if (typeof(T) == typeof(SubjectScoreRate))
                    return context.SubjectScoreRates.Where(x => x == target).ToList<BaseModel>();

                if (typeof(T) == typeof(User))
                    return context.Users.Where(x => x == target).ToList<BaseModel>();
            }
            return null;
        }

        public async Task<List<BaseModel>> SelectAllAsync()
        {
            using (SERDBContext context = _context.Create())
            {
                if (typeof(T) == typeof(Division))
                    return await context.Divisions.
                        Include(x => x.Subjects).
                        ThenInclude(x => x.SubjectScores).
                        Include(x => x.Subjects).ThenInclude(x => x.SubjectScoreRate).ToListAsync<BaseModel>();

                if (typeof(T) == typeof(EducationalInstitution))
                    return await context.EducationalInstitutions.ToListAsync<BaseModel>();

                if (typeof(T) == typeof(InstitutionDivision))
                    return await context.InstitutionDivisions.ToListAsync<BaseModel>();

                if (typeof(T) == typeof(Student))
                    return await context.Students.ToListAsync<BaseModel>();

                if (typeof(T) == typeof(StudentSubjectScore))
                    return await context.StudentSubjectScores.ToListAsync<BaseModel>();

                if (typeof(T) == typeof(StudentSubjectManged))
                    return await context.StudentSubjectMangeds.ToListAsync<BaseModel>();

                if (typeof(T) == typeof(Subject))
                    return await context.Subjects.ToListAsync<BaseModel>();

                if (typeof(T) == typeof(SubjectScore))
                    return await context.SubjectScores.ToListAsync<BaseModel>();

                if (typeof(T) == typeof(SubjectScoreRate))
                    return await context.SubjectScoreRates.ToListAsync<BaseModel>();

                if (typeof(T) == typeof(User))
                    return await context.Users.ToListAsync<BaseModel>();
            }
            return null;
        }

        public async Task<List<BaseModel>> SelectAllAsync(bool active)
        {
            using (SERDBContext context = _context.Create())
            {
                if (typeof(T) == typeof(Division))
                    return await context.Divisions.Where(x => x.Active == active).
                        Include(x => x.Subjects).
                        ThenInclude(x => x.SubjectScores).
                        Include(x => x.Subjects).ThenInclude(x => x.SubjectScoreRate).ToListAsync<BaseModel>();

                if (typeof(T) == typeof(EducationalInstitution))
                    return await context.EducationalInstitutions.Where(x => x.Active == active).ToListAsync<BaseModel>();

                if (typeof(T) == typeof(InstitutionDivision))
                    return await context.InstitutionDivisions.Where(x => x.Active == active).ToListAsync<BaseModel>();

                if (typeof(T) == typeof(Student))
                    return await context.Students.Where(x => x.Active == active).ToListAsync<BaseModel>();

                if (typeof(T) == typeof(StudentSubjectScore))
                    return await context.StudentSubjectScores.Where(x => x.Active == active).ToListAsync<BaseModel>();

                if (typeof(T) == typeof(StudentSubjectManged))
                    return await context.StudentSubjectMangeds.Where(x => x.Active == active).ToListAsync<BaseModel>();

                if (typeof(T) == typeof(Subject))
                    return await context.Subjects.Where(x => x.Active == active).ToListAsync<BaseModel>();

                if (typeof(T) == typeof(SubjectScore))
                    return await context.SubjectScores.Where(x => x.Active == active).ToListAsync<BaseModel>();

                if (typeof(T) == typeof(SubjectScoreRate))
                    return await context.SubjectScoreRates.Where(x => x.Active == active).ToListAsync<BaseModel>();

                if (typeof(T) == typeof(User))
                    return await context.Users.Where(x => x.Active == active).ToListAsync<BaseModel>();
            }
            return null;
        }

        public async Task<List<BaseModel>> SelectAllAsync(T target)
        {
            using (SERDBContext context = _context.Create())
            {
                if (typeof(T) == typeof(Division))
                    return await context.Divisions.Where(x => x == target).
                        Include(x => x.Subjects).
                        ThenInclude(x => x.SubjectScores).
                        Include(x => x.Subjects).ThenInclude(x => x.SubjectScoreRate)
                        .ToListAsync<BaseModel>();

                if (typeof(T) == typeof(EducationalInstitution))
                    return await context.EducationalInstitutions.Where(x => x == target as EducationalInstitution).ToListAsync<BaseModel>();

                if (typeof(T) == typeof(InstitutionDivision))
                    return await context.InstitutionDivisions.Where(x => x == target as InstitutionDivision).ToListAsync<BaseModel>();

                if (typeof(T) == typeof(Student))
                    return await context.Students.Where(x => x == target as Student).ToListAsync<BaseModel>();

                if (typeof(T) == typeof(StudentSubjectScore))
                    return await context.StudentSubjectScores.Where(x => x == target as StudentSubjectScore).ToListAsync<BaseModel>();

                if (typeof(T) == typeof(StudentSubjectManged))
                    return await context.StudentSubjectMangeds.Where(x => x == target as StudentSubjectManged).ToListAsync<BaseModel>();

                if (typeof(T) == typeof(Subject))
                    return await context.Subjects.Where(x => x == target as Subject).ToListAsync<BaseModel>();

                if (typeof(T) == typeof(SubjectScore))
                    return await context.SubjectScores.Where(x => x == target as SubjectScore).ToListAsync<BaseModel>();

                if (typeof(T) == typeof(SubjectScoreRate))
                    return await context.SubjectScoreRates.Where(x => x == target as SubjectScoreRate).ToListAsync<BaseModel>();

                if (typeof(T) == typeof(User))
                    return await context.Users.Where(x => x == target as User).ToListAsync<BaseModel>();
            }
            return null;
        }
    }
}