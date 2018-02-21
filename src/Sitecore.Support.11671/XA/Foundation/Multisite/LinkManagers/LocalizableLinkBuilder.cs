using Sitecore.Links;
using Sitecore.Support.XA.Foundation.SitecoreExtensions.Extensions;
using Sitecore.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sitecore.Support.XA.Foundation.Multisite.LinkManagers
{
  public class LocalizableLinkBuilder: Sitecore.XA.Foundation.Multisite.LinkManagers.LocalizableLinkBuilder
  {
    public LocalizableLinkBuilder(UrlOptions options) : base(options)
    {
    }
    protected override string GetServerUrlElement(SiteInfo siteInfo) => siteInfo.GetServerUrlElement(base.AlwaysIncludeServerUrl);
  }
}