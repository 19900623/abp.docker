using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Bpo.Roles.Dto;
using Bpo.Users.Dto;

namespace Bpo.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
