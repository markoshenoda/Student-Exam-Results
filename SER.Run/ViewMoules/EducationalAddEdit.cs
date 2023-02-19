using DataBaseManger.Modules;
using SER.Run.Commands;
using System.Windows.Input;

namespace SER.Run.ViewMoules
{
    public class EducationalAddEdit : ViewModuleBase
    {
        private readonly AdminHomeViewModule _adminHomeViewModule;

        public EducationalAddEdit(AdminHomeViewModule adminHomeViewModule, EducationalInstitution educationalInstitution)
        {
            _adminHomeViewModule = adminHomeViewModule;
            _educationalInstitution = educationalInstitution;
            EditCommand = new RelayCommand(EducationalEdit);
            DeleteCommand = new RelayCommand(EducationalDelete);
        }

        public EducationalInstitution _educationalInstitution;

        public ICommand EditCommand { get; }

        public ICommand DeleteCommand { get; }

        public string Name { get => _educationalInstitution.Name; }

        void EducationalEdit()
        {
            //_adminHomeViewModule.CurrentModalViewModel = new AddEditeEducationalInstitutionsViewModul(_adminHomeViewModule, this);
            //_adminHomeViewModule.IsModalOpen = true;
        }

        void EducationalDelete()
        {

        }
    }
}