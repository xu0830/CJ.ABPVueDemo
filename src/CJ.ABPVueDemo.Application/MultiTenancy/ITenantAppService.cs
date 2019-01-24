using Abp.Application.Services;
using Abp.Application.Services.Dto;
using CJ.ABPVueDemo.MultiTenancy.Dto;

namespace CJ.ABPVueDemo.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

