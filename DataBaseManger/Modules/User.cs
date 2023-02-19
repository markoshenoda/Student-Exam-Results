using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataBaseManger.Modules
{
    public class User : BaseModel
    {
        public User()
        {
            Active = true;
            InstitutionDivisions = new();
            UserAccess = UserAccess.User;
            MustChangePass = true;
            Pass = "123";
            IsLogin = false;
        }
        public int Id { get; set; }

        public string Name { get; set; }

        [MaxLength(14)]
        public string NID { get; set; }

        public string Pass { get; set; }

        public bool MustChangePass { get; set; }

        public bool Active { get; set; }

        public bool CanLogin { get; set; }

        public bool IsLogin { get; set; }

        public UserAccess UserAccess { get; set; }

        public List<InstitutionDivision> InstitutionDivisions { get; set; }
    }
}
