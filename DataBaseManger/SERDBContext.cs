using DataBaseManger.Modules;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseManger
{
    public class SERDBContext : DbContext
    {
        public SERDBContext(DbContextOptions options) : base(options) { }

        public DbSet<Division> Divisions { get; set; }

        public DbSet<EducationalInstitution> EducationalInstitutions { get; set; }

        public DbSet<MainDataBaseVerison> MainDataBaseVerison { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<StudentSubjectManged> StudentSubjectMangeds { get; set; }

        public DbSet<StudentSubjectScore> StudentSubjectScores { get; set; }

        public DbSet<Subject> Subjects { get; set; }

        public DbSet<SubjectScore> SubjectScores { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<SubjectScoreRate> SubjectScoreRates { get; set; }

        public DbSet<InstitutionDivision> InstitutionDivisions { get; set; }
    }
}
