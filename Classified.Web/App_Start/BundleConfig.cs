using System.Web;
using System.Web.Optimization;

namespace Classified.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                      "~/Scripts/app/main.js"));

            bundles.Add(new StyleBundle("~/Content/cssBundle").Include(
                      "~/Content/bootstrap-custom.css",
                      "~/Content/css/font-awesome.css",
                      "~/Content/common.css",
                      "~/Content/nav-menu.css",
                      "~/Content/footer.css",
                      "~/Content/navbar-search.css",
                      "~/Content/banner-full.css",
                      "~/Content/search-toolbar.css",
                      "~/Content/image-aspect-ratio.css"));

            BundleTable.EnableOptimizations = false;
        }
        
    }
}
