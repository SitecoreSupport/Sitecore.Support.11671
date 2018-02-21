using Sitecore.Links;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sitecore.Support.XA.Foundation.Multisite.LinkManagers
{
  public class LocalizableLinkProvider: Sitecore.XA.Foundation.Multisite.LinkManagers.LocalizableLinkProvider
  {
    public LocalizableLinkProvider():base()
        {
    }

    protected override LinkProvider.LinkBuilder CreateLinkBuilder(UrlOptions options) => new LocalizableLinkBuilder(options);
  }
}