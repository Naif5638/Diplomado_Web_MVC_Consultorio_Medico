using System.Web;
using System.Web.Mvc;

namespace Diplomado_Web_MVC_Consultorio_Medico
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
