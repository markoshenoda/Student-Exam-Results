using SER.Run.Commands;
using DataBaseManger.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using SER.Run.ViewMoules.Windows;

namespace SER.Run.ViewMoules
{
    public class LoginViewModule : ViewModuleBase
    {
        public LoginViewModule()
        {
            User = new User()
            {
                Id = 0,
                Pass = "0"
            };
        }

        public ICommand CLoginCommand { get; }

        private string _userCode;

        public string UserCode { get => _userCode;
            set { _userCode = value; UpdateUser(); }
        }

        private string _userPass;

        public string UserPass { get => _userPass;
            set { _userPass = value; UpdateUser(); }
        }

        public User User { get; private set; }

        void UpdateUser()
        {
            if (!string.IsNullOrEmpty(UserCode))
                User.Id = int.Parse(UserCode);

            if (!string.IsNullOrEmpty(UserPass))
                User.Pass = UserPass;
        }
    }
}