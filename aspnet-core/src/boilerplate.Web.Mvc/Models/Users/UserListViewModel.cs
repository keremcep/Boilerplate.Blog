using System.Collections.Generic;
using boilerplate.Roles.Dto;

namespace boilerplate.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
