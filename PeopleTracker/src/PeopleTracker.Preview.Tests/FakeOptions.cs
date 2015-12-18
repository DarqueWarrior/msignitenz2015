namespace PeopleTracker.Preview.Tests
{
   using Microsoft.Framework.OptionsModel;

   public class FakeOptions : IOptions<SiteOptions>
   {
      private SiteOptions _value;

      public FakeOptions(SiteOptions value)
      {
         _value = value;
      }

      public SiteOptions Value
      {
         get
         {
            return _value;
         }
      }
   }
}
