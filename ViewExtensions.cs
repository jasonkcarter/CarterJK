using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarterJK
{
    public static class ViewExtensions
    {
        public static string GetRouteData(this HtmlHelper html, string name)
        {
            object value;
            if (!html.ViewContext.RouteData.Values.TryGetValue(name, out value) || !(value is string))
            {
                value = string.Empty;
            }
            return (string) value;
        }
    }
}