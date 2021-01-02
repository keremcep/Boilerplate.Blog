using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using boilerplate.Controllers;

namespace boilerplate.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : boilerplateControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
