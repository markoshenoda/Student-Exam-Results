using DataBaseManger.Modules;
using SER.Run.Commands;
using System.Collections.Generic;
using System.Windows.Input;

namespace SER.Run.ViewMoules
{
    public class DivisionAddEdit : ViewModuleBase
    {
        public DivisionAddEdit(AdminHomeViewModule adminHomeViewModule, Division division)
        {
            _adminHomeViewModule = adminHomeViewModule;
            _division = division;
            EditCommand = new RelayCommand(DivisionEdit);
            DeleteCommand = new RelayCommand(DivisionDelete);
        }

        private readonly AdminHomeViewModule _adminHomeViewModule;

        public Division _division;

        public List<Division> Divisions { get => _division.SubDivisions; }

        public ICommand EditCommand { get; }

        public ICommand DeleteCommand { get; }

        public string Name { get => _division.Name; }

        void DivisionEdit()
        {
            _adminHomeViewModule.CurrentModalViewModel = new AddEditeEducationalInstitutionsViewModul(_adminHomeViewModule);
            _adminHomeViewModule.IsModalOpen = true;
        }

        void DivisionDelete()
        {

        }
    }
}