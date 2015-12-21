namespace PeopleTracker.NetService.Tests.Controllers
{
   using Microsoft.VisualStudio.TestTools.UnitTesting;
   using PeopleTracker.NetService.Controllers;
   using System.Web.Mvc;

   [TestClass]
   public class HomeControllerTest
   {
      [TestMethod]
      [TestCategory("Unit")]
      public void Index()
      {
         // Arrange
         HomeController controller = new HomeController();

         // Act
         ViewResult result = controller.Index() as ViewResult;

         // Assert
         Assert.IsNotNull(result);
         Assert.AreEqual("Home Page", result.ViewBag.Title);
      }
   }
}
