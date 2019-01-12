using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using com.empower.Authorization;

namespace com.empower
{
    [DependsOn(
        typeof(empowerCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class empowerApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<empowerAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(empowerApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
