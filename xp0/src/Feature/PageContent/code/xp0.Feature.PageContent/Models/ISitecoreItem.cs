using Sitecore.Globalization;
using System;
using System.Collections.Generic;
using Glass.Mapper.Sc.Configuration.Attributes;

namespace xp0.Feature.PageContent.Models
{
    public interface ISitecoreItem : IComparable<ISitecoreItem>, IEquatable<ISitecoreItem>
    {
        Guid Id { get; set; }
        Language Language { get; set; }
        int Version { get; set; }
        Guid TemplateId { get; set; }
        IEnumerable<Guid> BaseTemplateIds { get; set; }
        string Name { get; set; }
        string DisplayName { get; set; }
        string Url { get; set; }
        string Path { get; set; }
        string FullPath { get; set; }
        [SitecoreChildren(InferType = true)]
        IEnumerable<ISitecoreItem> Children { get; set; }
    }
}