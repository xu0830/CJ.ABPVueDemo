using System.Threading.Tasks;
using Abp.Application.Services;
using CJ.ABPVueDemo.Sessions.Dto;

namespace CJ.ABPVueDemo.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
