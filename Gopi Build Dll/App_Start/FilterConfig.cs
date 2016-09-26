using System.Web;
using System.Web.Mvc;

namespace Gopi_Build_Dll
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}