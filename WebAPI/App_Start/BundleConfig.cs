using System.Web;
using System.Web.Optimization;

namespace WebAPI
{
    public class BundleConfig
    {
        /// For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/styles.24f154a169d9024f2b08.bundle.css"));


            bundles.Add(new ScriptBundle("~/Scripts/js").Include(
                        "~/Scripts/inline.ca572d99bce1b0cdb50e.bundle.js",
                        "~/Scripts/polyfills.d35e9a8ce7d2d97b6eb4.bundle.js",
                        "~/Scripts/scripts.7205410600178e697f36.bundle.js",
                        "~/Scripts/vendor.9898be9bb7afdaa8a784.bundle.js",
                        "~/Scripts/main.3fd08ab9bb633093e005.bundle.js"));
        }
    }
}
