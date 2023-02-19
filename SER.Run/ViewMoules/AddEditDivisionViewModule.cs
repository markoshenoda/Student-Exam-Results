using DataBaseManger.DBCommand;
using DataBaseManger.Modules;
using SER.Run.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace SER.Run.ViewMoules
{
    public class AddEditDivisionViewModule : ViewModuleBase
    {
        private Division _division;

        private Division _subDivision;

        private readonly AdminHomeViewModule _callerview;

        private DivisionAddEdit _divisionAddEdit;

        private bool _isDivisionEdit;

        private bool _isSubDivisionEdit;

        public AddEditDivisionViewModule(AdminHomeViewModule callerview)
        {
            _isSubDivisionEdit = false;
            _isDivisionEdit = false;
            _callerview = callerview;
            addCommand = new(App.localDB);
            mainAddCommand = new(App.mainDB);
            mainUpdateCommand = new(App.mainDB);
            updateCommand = new UpdateCommand(App.localDB);
            Divisions = new ObservableCollection<Division>(new SelectAllCommand<Division>(App.localDB).SelectAll(true).ConvertAll(x => (Division)x).FindAll(x => x.MainDivision.Id == 0));
            _division = new();
            _subDivision = new();
            AddDivisionCommand = new RelayCommand(AddDivision, CanAddDivision);
            AddSubDivisionCommand = new RelayCommand(AddSubDivision, CanAddSubDivision);
            SaveCommand = new RelayCommand(Save, CanSave);
            DivStyle = (Style)Application.Current.Resources["AddButton"];
            SubDivStyle = (Style)Application.Current.Resources["AddButton"];
        }

        public AddEditDivisionViewModule(AdminHomeViewModule callerview, DivisionAddEdit divisionAddEdit, bool mainDivision) : this(callerview)
        {
            _divisionAddEdit = divisionAddEdit;
            if (mainDivision)
            {
                _isDivisionEdit = true;
                DivStyle = (Style)Application.Current.Resources["EditButton"];
                _division = divisionAddEdit._division;
            }
            else
            {
                _isSubDivisionEdit = true;
                SubDivStyle = (Style)Application.Current.Resources["EditButton"];
                _subDivision = divisionAddEdit._division;
                SelectedDivision = divisionAddEdit._division.MainDivision;
                _divisionAddEdit = divisionAddEdit;
                _divisionAddEdit.Divisions.Remove(_divisionAddEdit._division);
            }
        }

        public Division SelectedDivision { get; set; }

        public ObservableCollection<Division> Divisions { get; private set; }

        public Style DivStyle { get; private set; }

        public Style SubDivStyle { get; private set; }

        public string DivisionName { get => _division.Name; set { _division.Name = value; _ = CanAddDivision(); } }

        public string SubDivisionName { get => _subDivision.Name; set { _subDivision.Name = value; _ = CanAddSubDivision(); } }

        public ICommand AddDivisionCommand { get; }

        public ICommand AddSubDivisionCommand { get; }

        public ICommand SaveCommand { get; }

        private void AddDivision()
        {
            if (!_isDivisionEdit)
            {
                _division.MainDivision.Id = 0;
                addCommand.Add(_division);
            }
            else
            {
                _ = ((InstitutionsDivisionsViewModule)_callerview.DataView).DivisionAddEdits.Remove(_divisionAddEdit);
                updateCommand.Update(_division);
                _isDivisionEdit = false;
            }
            Divisions.Add(_division);
            ((InstitutionsDivisionsViewModule)_callerview.DataView).DivisionAddEdits.Add(new DivisionAddEdit(_callerview, _division));
            _division = new();
            DivisionName = string.Empty;
            _ = CanSave();
        }

        private void AddSubDivision()
        {
            _subDivision.MainDivision = SelectedDivision;
            if (!_isSubDivisionEdit)
            {
                addCommand.Add(_subDivision);
            }
            else
            {
                _ = ((InstitutionsDivisionsViewModule)_callerview.DataView).DivisionAddEdits.Remove(_divisionAddEdit);
                updateCommand.Update(_subDivision);
                _isSubDivisionEdit = false;
            }
            Divisions.FirstOrDefault((x) => x.Name == SelectedDivision.Name).SubDivisions.Add(_subDivision);
            ((InstitutionsDivisionsViewModule)_callerview.DataView).DivisionAddEdits.Add(new DivisionAddEdit(_callerview, _division));
            _division = new();
            SubDivisionName = string.Empty;
            _ = CanSave();
        }

        private void Save()
        {
            if (_isDivisionEdit || _isSubDivisionEdit)
            {
                mainUpdateCommand.Update(Divisions.ToList());
            }
            else
            {
                mainAddCommand.Add(Divisions.ToList());
            }
        }

        private bool CanAddDivision()
        {
            return !string.IsNullOrEmpty(DivisionName);
        }

        private bool CanAddSubDivision()
        {
            return !string.IsNullOrEmpty(SubDivisionName) && SelectedDivision != null;
        }

        private bool CanSave()
        {
            return Divisions != null && Divisions.Count > 0;
        }
    }
}