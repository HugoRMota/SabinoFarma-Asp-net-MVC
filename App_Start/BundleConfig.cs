using System.Web;
using System.Web.Optimization;

namespace SabinoFarma
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        
                         "~/Scripts/jquery.js",
                        "~/Scripts/jquery-migrate-1.2.1.min.js","~/Scripts/device.min.js"
                     ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*",
                        "~/Scripts/jquery.validate.unobtrusive.js",
                        "~/Scripts/jquery.unobtrusive-ajax.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                   "~/Scripts/bootstrap.js",
                   "~/Scripts/tm-scripts.js",  
                   "~/Scripts/respond.js",                      
                   "~/Scripts/html5shiv.js"
                      ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                       "~/Content/animate.css",
                       "~/Content/bootstrap.css",
                       "~/Content/search.css", 
                       "~/Content/camera.css",                
                       "~/Content/google-map.css",
                       "~/Content/contact-form.css"
                      ));
        }
    }
}
