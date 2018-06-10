using System.Web;
using System.Web.Mvc;

namespace Hefec.Studay.SampleMVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
