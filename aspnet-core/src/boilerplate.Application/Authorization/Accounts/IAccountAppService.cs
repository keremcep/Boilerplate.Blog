using System.Threading.Tasks;
using Abp.Application.Services;
using boilerplate.Authorization.Accounts.Dto;

namespace boilerplate.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
