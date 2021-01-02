﻿using System.Collections.Generic;
using boilerplate.Roles.Dto;

namespace boilerplate.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
