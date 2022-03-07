using System.Web;
using System.Web.Mvc;

namespace Ass2_Shopping_Basket
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
