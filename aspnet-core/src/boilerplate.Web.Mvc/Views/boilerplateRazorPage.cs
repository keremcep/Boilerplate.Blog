using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace boilerplate.Web.Views
{
    public abstract class boilerplateRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected boilerplateRazorPage()
        {
            LocalizationSourceName = boilerplateConsts.LocalizationSourceName;
        }
    }
}
