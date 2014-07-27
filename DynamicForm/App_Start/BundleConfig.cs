using System.Web.Optimization;

namespace DynamicForm
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Scripts/jquery").Include(
                "~/Scripts/jquery-{version}.js",
                "~/Scripts/jquery.*",
                "~/Scripts/jquery-ui-{version}.js",
                "~/Scripts/jsviews.js")
            );
            bundles.Add(new StyleBundle("~/Content/bootstrap")
                .Include("~/Content/bootstrap.css")
                .Include("~/Content/bootstrap-theme.css"));

            bundles.Add(new StyleBundle("~/Content/css")
                .Include("~/Content/main.css")
                .Include("~/Content/themes/base/*.css"));
        }
    }
}