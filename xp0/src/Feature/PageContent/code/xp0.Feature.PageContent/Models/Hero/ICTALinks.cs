using Glass.Mapper.Sc.Fields;
using xp0.Feature.PageContent.Models;


namespace xp0.Feature.PageContent.Models.Hero
{
    public interface ICTALinks : ISitecoreItem
    {
        Link Link { get; set; }
    }
}