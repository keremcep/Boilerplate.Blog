using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using boilerplate.Authorization;

namespace boilerplate
{
    [DependsOn(
        typeof(boilerplateCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class boilerplateApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<boilerplateAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(boilerplateApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
