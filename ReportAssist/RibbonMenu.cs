using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using Base;
using Core;
using Newtonsoft.Json.Linq;

namespace PPTPlugin
{
    public partial class RibbonMenu
    {
        private void RibbonMenu_Load(object sender, RibbonUIEventArgs e)
        {
            Request.HttpLogin("", "");
        }

        private void button_login_Click(object sender, RibbonControlEventArgs e)
        {
            
        }

        private async void button_temp_Click(object sender, RibbonControlEventArgs e)
        {
            List<ResourceData> imageList = await RequestHandle.GetTempList();
            Globals.ThisAddIn.RightWidget.UpdateResourceList(imageList);
            Globals.ThisAddIn.TaskWidget.Visible = true;
        }

        private async void button_sign_Click(object sender, RibbonControlEventArgs e)
        {
            List<ResourceData> imageList = await RequestHandle.GetSignList();
            Globals.ThisAddIn.RightWidget.UpdateResourceList(imageList);
            Globals.ThisAddIn.TaskWidget.Visible = true;
        }

        private async void button_icon_Click(object sender, RibbonControlEventArgs e)
        {
            List<ResourceData> imageList = await RequestHandle.GetIconList();
            Globals.ThisAddIn.RightWidget.UpdateResourceList(imageList);
            Globals.ThisAddIn.TaskWidget.Visible = true;
        }

        private async void button_image_Click(object sender, RibbonControlEventArgs e)
        {
            
        }

        private void button_label_Click(object sender, RibbonControlEventArgs e)
        {

        }
    }
}
