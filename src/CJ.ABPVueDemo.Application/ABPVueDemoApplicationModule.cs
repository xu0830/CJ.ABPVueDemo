using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using CJ.ABPVueDemo.Authorization;

namespace CJ.ABPVueDemo
{
    [DependsOn(
        typeof(ABPVueDemoCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ABPVueDemoApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ABPVueDemoAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ABPVueDemoApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
