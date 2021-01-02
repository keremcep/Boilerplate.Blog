using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using boilerplate.Configuration;

namespace boilerplate.Web.Host.Startup
{
    [DependsOn(
       typeof(boilerplateWebCoreModule))]
    public class boilerplateWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public boilerplateWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(boilerplateWebHostModule).GetAssembly());
        }
    }
}
