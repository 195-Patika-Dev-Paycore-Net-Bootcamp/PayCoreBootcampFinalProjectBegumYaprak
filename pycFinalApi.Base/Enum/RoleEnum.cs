using System.ComponentModel;

namespace pycFinalApi.Base
{
    public class Role
    {
        public const string Admin = "admin";
        public const string User = "user";
    
    }

    public enum RoleEnum
    {
        [Description(Role.Admin)]
        Admin = 1,

        [Description(Role.User)]
        User = 2,

}

}
