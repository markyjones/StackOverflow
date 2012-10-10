using System.Web;
using System.Web.Mvc;

namespace ExampleMvc4WithNinject
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}