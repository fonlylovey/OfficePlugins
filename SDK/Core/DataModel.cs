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
        public String MarkFlag { set; get; } = String.Empty;
    }

    public class ResourceModel
    {
        public int PageCount { set; get; } = 0;
        public int ResCount { set; get; } = 0;

        public List<ResourceData> ResourceList = new List<ResourceData>();
    }

    public enum ResourceType
    {
        None = -1,
        Template = 0, //模板
        Icon = 1, //图标
        Legend = 2, //图例
        Market = 3,//市场
        Policy = 4, //政策
        Product = 5, //产品
        Predict = 6, //预测
        Macro = 7, //宏观
        Upload_template = 8,
        Upload_icon = 9,
        Upload_legend = 10,
        Wdsc = 11, //我的收藏
        Lsjl = 12, //历史记录
        qb = 13, //全部
        Enterprise = 14, //企业
        Technology = 15 //技术
    }
}
