using DataBaseManger.DBCommand;
using DataBaseManger.Modules;
using SER.Run.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace SER.Run.ViewMoules
{
    public class AddEditSubjectsViewModule : ViewModuleBase
    {
        AdminHomeViewModule _callerView;
        bool edit;
        public AddEditSubjectsViewModule(AdminHomeViewModule callerView)
        {
            addCommand = new AddCommand(App.localDB);
            updateCommand = new UpdateCommand(App.localDB);
            selectCommand = new SelectCommand(App.localDB);

            edit = false;
            _callerView = callerView;
            CancelCommand = new RelayCommand(Close);
            Title = "أضافة المواد التعليمية";

            Divisions = new SelectAllCommand<Division>(App.localDB).SelectAll(true).ConvertAll(x => (Division)x);

            SubjectScoreRates = new SelectAllCommand<SubjectScoreRate>(App.localDB).SelectAll(true).ConvertAll(x => (SubjectScoreRate)x);

            _subject = new Subject();

            _subject.Divisions = new List<Division>();

            _subjectScoreRate = new SubjectScoreRate() { Active = true };

            AddSubjectCommand = new RelayCommand(AddSubject, CanAdd);
            AddScoreRateCommand = new RelayCommand(AddScourRate);
            CloseScoreRateCommand = new RelayCommand(CloseScourRate);
            SaveScoreRateCommand = new RelayCommand(SaveScoreRate, CanAddScoreRate);
        }

        public AddEditSubjectsViewModule(AdminHomeViewModule callerView, Subject subject)
        {
            addCommand = new AddCommand(App.localDB);
            updateCommand = new UpdateCommand(App.localDB);
            selectCommand = new SelectCommand(App.localDB);
            edit = false;
            _callerView = callerView;
            CancelCommand = new RelayCommand(Close);
            Title = "تعديل المواد التعليمية";

            Divisions = new List<Division>();

            //SubjectScoreRates = new List<SubjectScoreRate>();

            _subject = subject;

            AddSubjectCommand = new RelayCommand(AddSubject, CanAdd);
        }

        public List<SubjectScoreRate> SubjectScoreRates { get; set; }

        public bool WithPractica { get; set; }

        public bool AddScoreRate { get; set; }

        private Subject _subject;

        SubjectScoreRate _subjectScoreRate;

        SubjectScoreRate _selectedSubjectScoreRate;

        public string ScoreRate { get => _subjectScoreRate.Name; set { _subjectScoreRate.Name = value; CanAddScoreRate(); } }

        public SubjectScoreRate SubjectScoreRate { get => _selectedSubjectScoreRate; set { _selectedSubjectScoreRate = value; CanAdd(); } }

        public string SubjectName { get => _subject.Name; set { _subject.Name = value; CanAdd(); } }

        public int PassMin { get => _subjectScoreRate.PassMin; set { _subjectScoreRate.PassMin = value; CanAddScoreRate(); } }

        public int Good { get => _subjectScoreRate.Good; set { _subjectScoreRate.Good = value; CanAddScoreRate(); } }

        public int VeryGood { get => _subjectScoreRate.VeryGood; set { _subjectScoreRate.VeryGood = value; CanAddScoreRate(); } }

        public int Excellent { get => _subjectScoreRate.Excellent; set { _subjectScoreRate.Excellent = value; CanAddScoreRate(); } }

        public ICommand AddSubjectCommand { get; }

        public ICommand AddScoreRateCommand { get; }

        public ICommand CloseScoreRateCommand { get; }

        public ICommand SaveScoreRateCommand { get; }

        public List<Division> SelectedDivisions { get => _subject.Divisions; set { _subject.Divisions = value; CanAdd(); } }

        public List<Division> Divisions { get; }

        private SubjectScore WrittenSubjectScore { get; set; } = new SubjectScore() { ScoreType = SubjectScoreType.WrittenExam, Active = true };

        private SubjectScore PracticalSubjectScore { get; set; } = new SubjectScore() { ScoreType = SubjectScoreType.PracticalExam, Active = true };

        private SubjectScore YearWorksSubjectScore { get; set; } = new SubjectScore() { ScoreType = SubjectScoreType.YearWorks, Active = true };

        public uint WMin { get => WrittenSubjectScore.MinimumScore; set { WrittenSubjectScore.MinimumScore = value; CanAdd(); } }

        public uint WMax { get => WrittenSubjectScore.MaximumScore; set { WrittenSubjectScore.MaximumScore = value; CanAdd(); } }

        public uint PMin { get => PracticalSubjectScore.MinimumScore; set { PracticalSubjectScore.MinimumScore = value; CanAdd(); } }

        public uint PMax { get => PracticalSubjectScore.MaximumScore; set { PracticalSubjectScore.MaximumScore = value; CanAdd(); } }

        public uint YMin { get => YearWorksSubjectScore.MinimumScore; set { YearWorksSubjectScore.MinimumScore = value; CanAdd(); } }

        public uint YMax { get => YearWorksSubjectScore.MaximumScore; set { YearWorksSubjectScore.MaximumScore = value; CanAdd(); } }

        void AddSubject()
        {
            if (!edit)
            {
                //List<Division> x = _subject.Divisions;
                //_subject.Divisions = new List<Division>();
                //SubjectScoreRate y = _subject.SubjectScoreRate;
                _subject.SubjectScores = new List<SubjectScore>();
                //_subject.SubjectScoreRate = new SubjectScoreRate();
                //addCommand.Add(PracticalSubjectScore);
                //addCommand.Add(WrittenSubjectScore);
                if (WithPractica)
                {
                    //addCommand.Add(YearWorksSubjectScore);
                    _subject.SubjectScores.Add(YearWorksSubjectScore);
                    WithPractica = false;
                }
                _subject.SubjectScores.Add(PracticalSubjectScore);
                _subject.SubjectScores.Add(WrittenSubjectScore);
                _subject.SubjectScoreRate = SubjectScoreRate;
                addCommand.Add(_subject);
                //_subject.Divisions = x;
                //_subject.SubjectScoreRate = y;
                //updateCommand.Update(_subject);
                _subject = new Subject() { Active = true, SubjectScores = new List<SubjectScore>() };
                //_subject.Divisions = x;
                return;
            }
        }

        bool CanAdd() => WMin > 0 && WMax > 0 && WMax > WMin && YMin > 0 && YMax > 0 && YMax > YMin
                         && !string.IsNullOrEmpty(SubjectName) && SubjectScoreRate != null && SelectedDivisions != null && SelectedDivisions.Count > 0;

        void Close() => _callerView.IsModalOpen = false;

        void AddScourRate() => AddScoreRate = true;

        void CloseScourRate() => AddScoreRate = false;

        void SaveScoreRate()
        {
            addCommand.Add(_subjectScoreRate);
            SubjectScoreRates.Add(_subjectScoreRate);
            PassMin = 0;
            Good = 0;
            VeryGood = 0;
            Excellent = 0;
            ScoreRate = string.Empty;
            _subjectScoreRate = null;
            _subjectScoreRate = new SubjectScoreRate() { Active = true };
        }

        bool CanAddScoreRate() => !string.IsNullOrEmpty(ScoreRate) && PassMin >= 50 && Good >= 55 && VeryGood >= 60 && Excellent >= 65;
    }
}