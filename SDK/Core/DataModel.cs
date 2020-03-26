using System;
using System.Collections.Generic;

namespace Core
{
    public class ResourceData
    {
        public String ID { set; get; } = String.Empty;
        public String Name { set; get; } = String.Empty;
        public String Label { set; get; } = String.Empty;
        public String IconUrl { set; get; } = String.Empty;
        public String FileUrl { set; get; } = String.Empty;
    }

    public class ResourceModel
    {
        public int PageCount { set; get; } = 0;

        public List<ResourceData> ResourceList = new List<ResourceData>();
    }

    public enum ResourceType
    {
        Template,
        Icon,
        legend
    }
}
