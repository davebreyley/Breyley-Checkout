using System.Web;
using System.Web.Optimization;

namespace DaveSuperMarket
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/DaveSupermarket")
                .IncludeDirectory("~/Scripts/Controllers", "*.js")
                .Include("~/Scripts/DaveSupermarket.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/site.css"));

            

            BundleTable.EnableOptimizations = true;
        }

    }
}
