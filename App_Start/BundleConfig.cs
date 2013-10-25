using System.Web;
using System.Web.Optimization;

namespace CarterJK
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                "~/Scripts/modernizr-*",
                "~/Scripts/require.js"));

            // jQuery
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Scripts/jquery-{version}.js"));

            // HTML5 shiv bundles
            bundles.Add(new ScriptBundle("~/bundles/html5shiv").Include(
                "~/Scripts/html5shiv.js"));
            bundles.Add(new ScriptBundle("~/bundles/html5shiv-printshiv").Include(
                "~/Scripts/html5shiv-printshiv.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/main.css", "~/Content/normalize.css"));
        }
    }
}