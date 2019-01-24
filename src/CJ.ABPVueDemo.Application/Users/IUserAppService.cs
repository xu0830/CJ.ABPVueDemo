using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using CJ.ABPVueDemo.Roles.Dto;
using CJ.ABPVueDemo.Users.Dto;

namespace CJ.ABPVueDemo.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
