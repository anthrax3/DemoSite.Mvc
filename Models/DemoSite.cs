﻿namespace DemoSite.Models {
    using KalikoCMS.Attributes;
    using KalikoCMS.Core;
    using KalikoCMS.PropertyType;
    using Pages;

    [SiteSettings(AllowedTypes = new[] { typeof(NewsListPage), typeof(StartPage), typeof(ProductListPage), typeof(ArticlePage), typeof(SearchPage), typeof(ContactPage) })]
    public class DemoSite : CmsSite {
        [Property("Company name")]
        public virtual StringProperty CompanyName { get; set; }

        [Property("Search page")]
        public virtual PageLinkProperty SearchPage { get; set; }
    }
}