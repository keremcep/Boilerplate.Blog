using Abp.AspNetCore.Mvc.ViewComponents;

namespace boilerplate.Web.Views
{
    public abstract class boilerplateViewComponent : AbpViewComponent
    {
        protected boilerplateViewComponent()
        {
            LocalizationSourceName = boilerplateConsts.LocalizationSourceName;
        }
    }
}
