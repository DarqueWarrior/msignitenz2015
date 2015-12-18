using Xunit;

namespace PeopleTracker.Preview.Tests
{
   public class HomeControllerTests
   {
      [Fact]
      public void Index()
      {
         // Arrange
         var target = new PeopleTracker.Preview.Controllers.HomeController(null);

         // Act
         var results = target.Index();

         // Assert
         Assert.NotNull(results);
      }
   }
}
