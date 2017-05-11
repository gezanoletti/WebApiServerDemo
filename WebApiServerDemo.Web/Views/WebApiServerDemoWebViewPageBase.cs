using Abp.Web.Mvc.Views;

namespace WebApiServerDemo.Web.Views
{
    public abstract class WebApiServerDemoWebViewPageBase : WebApiServerDemoWebViewPageBase<dynamic>
    {

    }

    public abstract class WebApiServerDemoWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected WebApiServerDemoWebViewPageBase()
        {
            LocalizationSourceName = WebApiServerDemoConsts.LocalizationSourceName;
        }
    }
}