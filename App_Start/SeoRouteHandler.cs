using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CarterJK.App_Start
{
    /// <summary>
    /// Used to automatically map hyphenated SEO-friendly urls to MVC controller actions that have no hyphens.
    /// </summary>
    public class SeoRouteHandler : MvcRouteHandler
    {
        /// <summary>
        /// Returns the HTTP handler by using the specified HTTP context.
        /// </summary>
        /// <param name="requestContext">The request context.</param>
        /// <returns>
        /// The HTTP handler.
        /// </returns>
        protected override IHttpHandler GetHttpHandler(RequestContext requestContext)
        {
            // Remove hypens from controller names
            string controllerName = requestContext.RouteData.Values["controller"].ToString();
            if (controllerName.IndexOf('-') > -1)
            {
                requestContext.RouteData.Values["controller"] = controllerName.Replace("-", string.Empty);
            }
            return base.GetHttpHandler(requestContext);
        }
    }
}