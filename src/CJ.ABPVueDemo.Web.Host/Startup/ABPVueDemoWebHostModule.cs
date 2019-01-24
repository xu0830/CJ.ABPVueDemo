using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using CJ.ABPVueDemo.Configuration;

namespace CJ.ABPVueDemo.Web.Host.Startup
{
    [DependsOn(
       typeof(ABPVueDemoWebCoreModule))]
    public class ABPVueDemoWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ABPVueDemoWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ABPVueDemoWebHostModule).GetAssembly());
        }
    }
}
