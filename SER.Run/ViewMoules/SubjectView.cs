using DataBaseManger.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SER.Run.ViewMoules
{
    public class SubjectView : ViewModuleBase
    {
        private readonly AdminHomeViewModule _adminHomeViewModule;
        public SubjectView(AdminHomeViewModule adminHomeViewModule,Subject subject)
        {
            _subject = subject;
            _adminHomeViewModule = adminHomeViewModule;
        }

        Subject _subject;

        public string Name { get => _subject.Name; }

        public ICommand EditCommand { get; }

        public ICommand DeleteCommand { get; }
    }
}