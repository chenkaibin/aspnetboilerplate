﻿using Abp.Web.Mvc.Views;

namespace Reation.CMS.Web.Views
{
    public abstract class CMSWebViewPageBase : CMSWebViewPageBase<dynamic>
    {

    }

    public abstract class CMSWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected CMSWebViewPageBase()
        {
            LocalizationSourceName = CMSConsts.LocalizationSourceName;
        }
    }
}