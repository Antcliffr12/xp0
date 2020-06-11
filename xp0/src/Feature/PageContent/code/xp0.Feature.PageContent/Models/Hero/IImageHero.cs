using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using System.Collections.Generic;
using xp0.Feature.PageContent.Models;


namespace xp0.Feature.PageContent.Models.Hero
{
    [SitecoreType(AutoMap = true)]
    public interface IImageHero : ISitecoreItem
    {
        string PageTitle { get; set; }
        string PageSummary { get; set; }
        Link CTALink { get; set; }
        Image Image { get; set; }

        [SitecoreChildren]
        IEnumerable<ICTALinks> Links { get; set; }
    }
}
