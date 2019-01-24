using System.Threading.Tasks;
using Abp.Application.Services;
using CJ.ABPVueDemo.Authorization.Accounts.Dto;

namespace CJ.ABPVueDemo.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
