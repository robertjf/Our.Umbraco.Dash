using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Web;
using Umbraco.Web.Models.Trees;
using Umbraco.Web.Trees;

namespace Our.Umbraco.Dash
{
    [Tree("developer", "dash", "Dash", iconClosed: "icon-dashboard")]
    public class DashTreeController : TreeController
    {
        protected override MenuItemCollection GetMenuForNode(string id, FormDataCollection queryStrings)
        {
            throw new NotImplementedException();
        }

        protected override TreeNodeCollection GetTreeNodes(string id, FormDataCollection queryStrings)
        {
            throw new NotImplementedException();
        }
    }
}