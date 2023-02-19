using DataBaseManger.Modules;
using System.Windows.Input;

namespace SER.Run.ViewMoules
{
    public class CahngePasswordViewModle : ViewModuleBase
    {
        private User _user;

        public CahngePasswordViewModle(User user)
        {
            _user = user;
        }

        public string UserName { get => _user.Name; }

        public string CurantPassword { get => _user.Pass; }

        public string NewPassword { get; set; }

        public bool MustChange { get=> !_user.MustChangePass; }

        public ICommand ChangePasswordCommand;

       
    }
}