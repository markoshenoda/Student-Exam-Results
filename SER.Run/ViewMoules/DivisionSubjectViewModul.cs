using DataBaseManger.DBCommand;
using DataBaseManger.Modules;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SER.Run.ViewMoules
{
    public class DivisionSubjectViewModul : ViewModuleBase
    {
        private readonly SelectAllCommand<Division> selectAllDivisionCommand;

        public DivisionSubjectViewModul(AdminHomeViewModule adminHomeViewModule)
        {
            selectAllDivisionCommand = new SelectAllCommand<Division>(App.localDB);

            Divisions = new ObservableCollection<Division>(selectAllDivisionCommand.SelectAll(true).ConvertAll(new Converter<BaseModel, Division>((x) => (Division)x)).FindAll(x => x.MainDivision.Id != 0));
            _division = new Division();
            DivisionSubjectViewModuls = new ObservableCollection<DivisionSubjectViewModul>();
            foreach (Division item in Divisions)
                DivisionSubjectViewModuls.Add(new DivisionSubjectViewModul(adminHomeViewModule, item));
        }

        public DivisionSubjectViewModul(AdminHomeViewModule adminHomeViewModule, Division division)
        {
            _division = division;
            SubjectViews = new ObservableCollection<SubjectView>();
            if (division.Subjects != null)
                foreach (Subject item in division.Subjects)
                    SubjectViews.Add(new SubjectView(adminHomeViewModule, item));
        }

        private Division _division;

        public string Name { get => _division.Name; }

        public ObservableCollection<DivisionSubjectViewModul> DivisionSubjectViewModuls { get; set; }


        private ObservableCollection<Division> Divisions;

        public ObservableCollection<SubjectView> SubjectViews { get; set; }
    }
}