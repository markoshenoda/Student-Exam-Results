using DataBaseManger.DBCommand;
using DataBaseManger.Modules;
using SER.Run.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SER.Run.ViewMoules
{
    public class AddEducationalInstitutionsViewModul : ViewModuleBase
    {
        private EducationalAddEdit _educationalAddEdit;

        private EducationalInstitution _educationalInstitution;

        private readonly AdminHomeViewModule _callerview;
        
        private bool _isEditEducatinal;

        public AddEducationalInstitutionsViewModul(AdminHomeViewModule callerview)
        {
            addCommand = new(App.localDB);
            updateCommand = new(App.localDB);
            _educationalInstitution = new();
            _callerview = callerview;
            _isEditEducatinal = false;
            AddCommand = new RelayCommand(AddEducationalInstituison, CanAddEducationalInstituison);
            Divisions = new ObservableCollection<Division>(new SelectAllCommand<Division>(App.localDB).SelectAll(true).ConvertAll(x => (Division)x).FindAll(x => x.MainDivision.Id != 0));
        }

        public string EducationalName
        {
            get => _educationalInstitution.Name;
            set
            {
                if (_educationalInstitution == null)
                    _educationalInstitution = new EducationalInstitution();
                _educationalInstitution.Name = value;
                _ = CanAddEducationalInstituison();
            }
        }

        public ICommand AddCommand { get; }

        public ICommand SaveCommand { get; }

        public List<Division> SelectedDivisions { get; set; }

        public ObservableCollection<Division> Divisions { get; private set; }

        public ObservableCollection<EducationalInstitution> Educationals { get; private set; }

        public string EduactinalName { get => _educationalInstitution.Name; set { _educationalInstitution.Name = value; _ = CanAddEducationalInstituison(); } }

        private bool CanAddEducationalInstituison() => !string.IsNullOrEmpty(EducationalName) && SelectedDivisions.Count > 0;

        private void AddEducationalInstituison()
        {
            if (!_isEditEducatinal)
            {
                foreach (Division item in SelectedDivisions)
                    _educationalInstitution.InstitutionDivisions.Add(new InstitutionDivision() { EducationalInstitution = _educationalInstitution, Division = item });
                addCommand.Add(_educationalInstitution);  
            }
            else
            {
                ((InstitutionsDivisionsViewModule)_callerview.DataView).EducationalAddEdits.Remove(_educationalAddEdit);
                updateCommand.Update(_educationalInstitution);
                _isEditEducatinal = false;
            }
            ((InstitutionsDivisionsViewModule)_callerview.DataView).EducationalAddEdits.Add(new EducationalAddEdit(_callerview, _educationalInstitution));
            //AddedEducational.Add(_educationalInstitution);
            _educationalInstitution = new();
            EducationalName = string.Empty;
        }
    }
}
