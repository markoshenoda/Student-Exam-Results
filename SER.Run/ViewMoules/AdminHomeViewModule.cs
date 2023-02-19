using DataBaseManger;
using DataBaseManger.DBCommand;
using DataBaseManger.Modules;
using Microsoft.EntityFrameworkCore;
using SER.Run.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace SER.Run.ViewMoules
{
    public class AdminHomeViewModule : ViewModuleBase
    {
        SelectAllCommand<Division> divisionSelectAllCommand;

        public AdminHomeViewModule()
        {
            divisionSelectAllCommand = new SelectAllCommand<Division>(App.localDB);
            Title = "أضافة وتعديل المؤسسات والأقسام التعليمية";
            AddCommand = new RelayCommand(Add);
            BaseModels = new ObservableCollection<BaseModel>(divisionSelectAllCommand.SelectAll(true));
            DataView = new InstitutionsDivisionsViewModule(this);
        }

        public ViewModuleBase CurrentModalViewModel { get; set; }

        public bool IsModalOpen { get; set; }

        SelectedView selectedViews;

        public ICommand AddCommand { get; }

        public SelectedView SelectedViews { get => selectedViews; set { selectedViews = value; ChangeSelected(); } }

        public List<SelectedView> MenuItemList { get => Enum.GetValues(typeof(SelectedView)).Cast<SelectedView>().ToList(); }

        public ObservableCollection<BaseModel> BaseModels { get; set; }

        public ViewModuleBase DataView { get; set; }

        void ChangeSelected()
        {
            BaseModels.Clear();
            using (SERDBContext context = App.localDB.Create())
            {
                switch (selectedViews)
                {
                    case SelectedView.EducationalInstitution:
                        DataView = new InstitutionsDivisionsViewModule(this);
                        Title = "أضافة وتعديل المؤسسات والأقسام التعليمية";
                        break;
                    case SelectedView.Student:
                        
                        Title = "أضافة وتعديل بيانات الطلاب";
                        break;
                    case SelectedView.StudentSubjectManged:

                        break;
                    case SelectedView.Subject:
                        DataView = new DivisionSubjectViewModul(this);
                        Title = "أضافة وتعديل المواد التعليمية";
                        break;
                    case SelectedView.User:
                        Title = "أضافة وتعديل بيانات المستخدمين";
                        break;
                }
            }
        }

        void Add()
        {
            switch (selectedViews)
            {
                case SelectedView.EducationalInstitution:
                    CurrentModalViewModel = new AddEditeEducationalInstitutionsViewModul(this);
                    break;
                case SelectedView.Subject:
                    CurrentModalViewModel = new AddEditSubjectsViewModule(this);
                    break;
                case SelectedView.User:
                    CurrentModalViewModel = new AddEditUserViewModule(this);
                    break;
                case SelectedView.Student:
                    CurrentModalViewModel = new AddEditStudentViewModule(this);
                    break;
                case SelectedView.StudentSubjectManged:
                    break;
            }
            IsModalOpen = true;
        }
    }
}