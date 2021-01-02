using System.Threading.Tasks;
using Abp.Application.Services;
using boilerplate.Sessions.Dto;

namespace boilerplate.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
