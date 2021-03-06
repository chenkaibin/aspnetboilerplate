﻿using Abp.Application.Services;

namespace Reation.CMS
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class CMSAppServiceBase : ApplicationService
    {
        protected CMSAppServiceBase()
        {
            LocalizationSourceName = CMSConsts.LocalizationSourceName;
        }
    }
}