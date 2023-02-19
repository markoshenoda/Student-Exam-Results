using DataBaseManger.DBCommand;
using DataBaseManger.Modules;
using System.ComponentModel;
using System.Windows.Input;

namespace SER.Run.ViewMoules
{
    public class ViewModuleBase : INotifyPropertyChanged
    {
        protected AddCommand addCommand;

        protected UpdateCommand updateCommand;

        protected AddCommand mainAddCommand;

        protected UpdateCommand mainUpdateCommand;

        protected SelectCommand selectCommand;

        public event PropertyChangedEventHandler PropertyChanged = (sendr, e) => { };

        public void OnPropertyChanged(string name)
        {
            if (name is null)
                return;
            PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        public string Title { get; set; }

        public ICommand CancelCommand { get; protected set; }
    }
}