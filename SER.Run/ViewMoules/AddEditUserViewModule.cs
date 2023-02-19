using DataBaseManger;
using DataBaseManger.DBCommand;
using DataBaseManger.Modules;
using Microsoft.EntityFrameworkCore;
using SER.Run.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace SER.Run.ViewMoules
{
    public class AddEditUserViewModule : ViewModuleBase
    {
        public AddEditUserViewModule(AdminHomeViewModule adminHomeViewModule)
        {
            addCommand = new AddCommand(App.localDB);
            updateCommand = new UpdateCommand(App.localDB);
            SelectedEducationalInstitution = new List<InstitutionDivision>();
            Title = "أضافة مستخدم جديد";

            CancelCommand = new RelayCommand(() => adminHomeViewModule.IsModalOpen = false);

            TargetUser = new User()
            {
                Pass = "123",
                Active = true,
                UserAccess = UserAccess.User,
                MustChangePass = true
            };

            using (SERDBContext context = App.localDB.Create())
            {
                EducationalInstitutions = context.EducationalInstitutions.Include(x => x.InstitutionDivisions).ThenInclude(x => x.Division).ToList();
            }

            AddOrEditCommand = new RelayCommand(AddUser, CanAdd);
        }

        public AddEditUserViewModule()
        {
            addCommand = new AddCommand(App.localDB);
            updateCommand = new UpdateCommand(App.localDB);
            SelectedEducationalInstitution = new List<InstitutionDivision>();
            Title = "أضافة مستخدم جديد";
            TargetUser = new User()
            {
                Pass = "123",
                Active = true,
                UserAccess = UserAccess.User,
                MustChangePass = true
            };
            using (SERDBContext context = App.localDB.Create())
            {
                EducationalInstitutions = context.EducationalInstitutions.Include(x => x.InstitutionDivisions).ThenInclude(x => x.Division).ToList();
            }
            AddOrEditCommand = new RelayCommand(AddUser, CanAdd);
        }

        public AddEditUserViewModule(User targetUser)
        {
            Title = "تعديل بيانات المستخدم";

            AddOrEditCommand = new RelayCommand(EditUser, CanAdd);

            TargetUser = targetUser;
        }

        public string UserName { get => TargetUser.Name; set { TargetUser.Name = value; CanAdd(); } }

        public string Password { get => TargetUser.Pass; set { TargetUser.Pass = value; CanAdd(); } }

        public string UNID { get => TargetUser.NID; set { TargetUser.NID = value; CanAdd(); } }

        public List<EducationalInstitution> EducationalInstitutions { get; }

        public ICommand AddOrEditCommand { get; }

        private User TargetUser;

        public List<InstitutionDivision> SelectedEducationalInstitution { get; set; }

        public UserAccess UserAccessState { get => TargetUser.UserAccess; set { TargetUser.UserAccess = value; } }

        public List<UserAccess> UserAccessComboBox => Enum.GetValues(typeof(UserAccess)).Cast<UserAccess>().ToList();

        private void AddUser()
        {
            Mange();
            addCommand.Add(TargetUser);
            TargetUser.InstitutionDivisions = SelectedEducationalInstitution;
            updateCommand.Update(TargetUser);
            TargetUser = null;
            TargetUser = new User() { Active = true, Pass = "123", MustChangePass = true };
            UserName = string.Empty;
            UNID = string.Empty;
        }

        private void EditUser()
        {
            Mange();
            TargetUser.InstitutionDivisions = SelectedEducationalInstitution;
            updateCommand.Update(TargetUser);
        }

        private void Mange()
        {
            switch (TargetUser.UserAccess)
            {
                case UserAccess.Admin:
                case UserAccess.Reader:
                    TargetUser.CanLogin = true;
                    break;
                case UserAccess.User:
                    TargetUser.CanLogin = false;
                    break;
            }
        }

        bool CanAdd() => !string.IsNullOrEmpty(UserName) && !string.IsNullOrEmpty(Password) && !string.IsNullOrEmpty(UNID) && SelectedEducationalInstitution.Count > 0;
    }
}