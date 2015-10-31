using System.Web;
using System.Web.Mvc;

namespace PeopleTracker.NetService
{
   public class FilterConfig
   {
      public static void RegisterGlobalFilters(GlobalFilterCollection filters)
      {
         filters.Add(new HandleErrorAttribute());
      }
   }
}
