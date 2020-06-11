using System;
using System.Collections.Generic;
using Sitecore.Globalization;


namespace xp0.Feature.PageContent.Models
{
    public class SitecoreItem : ISitecoreItem
    {
        public int CompareTo(ISitecoreItem other)
        {
            return Id.CompareTo(other.Id);
        }

        public bool Equals(ISitecoreItem other)
        {
            return Id.Equals(other?.Id);
        }

        public override string ToString()
        {
            return $"{FullPath}|{Id}|{TemplateId}";
        }

        public Guid Id { get; set; }
        public Language Language { get; set; }
        public int Version { get; set; }
        public Guid TemplateId { get; set; }
        public IEnumerable<Guid> BaseTemplateIds { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Url { get; set; }
        public string Path { get; set; }
        public string FullPath { get; set; }
        public IEnumerable<ISitecoreItem> Children { get; set; }
    }
}