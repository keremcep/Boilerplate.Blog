using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using boilerplate.EntityFrameworkCore;
using boilerplate.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace boilerplate.Web.Tests
{
    [DependsOn(
        typeof(boilerplateWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class boilerplateWebTestModule : AbpModule
    {
        public boilerplateWebTestModule(boilerplateEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(boilerplateWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(boilerplateWebMvcModule).Assembly);
        }
    }
}