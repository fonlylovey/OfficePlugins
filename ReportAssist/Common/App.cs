using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPTPlugin
{
    public class App
    {
        public static ResourceType ResourceType = ResourceType.Template;
    }

    public class GroupItem
    {
        public GroupItem(String name = "")
        {
            Name = name;
        }
        public string ID { get; set; }
        public string Name { get; set; }
        public bool isChecked = false;
        public List<GroupItem> Children = new List<GroupItem>();
    }

    public class Contart
    {
        public string HeadUrl { get; internal set; }
        public bool IsLastMessage { get; internal set; }
        public string LastMessage { get; internal set; }
        public DateTime? LastMessageTime { get; internal set; }
        public string NickName { get; internal set; }
    }
}
