using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Bpo.MultiTenancy.Dto;

namespace Bpo.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

