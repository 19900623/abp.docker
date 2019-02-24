using System.Threading.Tasks;
using Abp.Application.Services;
using Bpo.Sessions.Dto;

namespace Bpo.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
