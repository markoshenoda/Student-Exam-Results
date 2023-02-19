using DataBaseManger.Modules;
using SER.Run.Commands;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Linq;
using DataBaseManger;
using System.Collections.Generic;
using DataBaseManger.DBCommand;
using System.Windows;

namespace SER.Run.ViewMoules
{
    public class AddEditeEducationalInstitutionsViewModul : ViewModuleBase
    {

        public AddEditeEducationalInstitutionsViewModul(AdminHomeViewModule callerview)
        {
            Title = "أضافة المؤسسات والأقسام التعليمية";
            AddDivision = new(callerview);
            AddEducationalInstitutionsViewModul = new(callerview);
            CancelCommand = new RelayCommand(() => callerview.IsModalOpen = false);
        }

        public AddEditDivisionViewModule AddDivision { get; }

        public AddEducationalInstitutionsViewModul AddEducationalInstitutionsViewModul { get; }
    }
}