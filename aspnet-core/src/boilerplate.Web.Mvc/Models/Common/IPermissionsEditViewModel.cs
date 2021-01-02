using System.Collections.Generic;
using boilerplate.Roles.Dto;

namespace boilerplate.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}