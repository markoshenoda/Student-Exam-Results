using DataBaseManger;
using DataBaseManger.DBCommand;
using DataBaseManger.Modules;
using Microsoft.EntityFrameworkCore;
using SER.Run.Commands;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace SER.Run.ViewMoules
{
    public class AddEditStudentViewModule : ViewModuleBase
    {
        AdminHomeViewModule _admin;
        public AddEditStudentViewModule(AdminHomeViewModule adminHomeViewModule)
        {
            _admin=adminHomeViewModule;
            addCommand = new AddCommand(App.localDB);
            CancelCommand = new RelayCommand(() => adminHomeViewModule.IsModalOpen = false);
            updateCommand = new UpdateCommand(App.localDB);

            Title = "أضافة الطلاب";

            student = new Student();

            using (SERDBContext context = App.localDB.Create())
                EducationalInstitutions = context.EducationalInstitutions.Include(x => x.InstitutionDivisions).ThenInclude(x => x.Division).ToList();

            AddOrEditCommand = new RelayCommand(Add);
            SaveCommand = new RelayCommand(Save);
        }

        private Student student;

        public string Message { get; set; }

        public ICommand AddOrEditCommand { get; }

        public ICommand SaveCommand { get; }

        public ObservableCollection<Student> Students { get; private set; }

        public List<EducationalInstitution> EducationalInstitutions { get; }

        InstitutionDivision selectedInDi;

        public InstitutionDivision SelectedInDi { get => selectedInDi; set { selectedInDi = value; CanAdd(); } }

        public uint Year { get; set; }

        public uint Code { get; set; }

        public string Name { get => student.Name; set { student.Name = value; CanAdd(); } }

        void Add()
        {
            if (Students == null)
                Students = new ObservableCollection<Student>();
            student.Code = Code;
            student.Year = Year;
            student.Stat = StudentStat.New;
            
            //await addCommand.AddAsync(student);
            student.InstitutionDivision = selectedInDi;
            //await updateCommand.UpdateAsync(student);

            Students.Add(student);

            Code++;
            student = null;
            student = new Student();
            Name = string.Empty;
        }

        void Save()
        {
            foreach (Student item in Students)
            {
                addCommand.Add(item);
            }
            Message = "Save Don!";
        }

        private bool CanAdd() => selectedInDi != null && Year >= 2020 && Code > 0 && !string.IsNullOrEmpty(Name);
    }
}