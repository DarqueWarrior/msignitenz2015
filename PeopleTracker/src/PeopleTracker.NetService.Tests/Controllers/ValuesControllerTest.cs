namespace PeopleTracker.NetService.Tests.Controllers
{
   using Microsoft.VisualStudio.TestTools.UnitTesting;
   using PeopleTracker.NetService.Controllers;
   using System.Collections.Generic;
   using System.Linq;

   [TestClass]
   public class ValuesControllerTest
   {
      [TestMethod]
      [TestCategory("Unit")]
      public void Get()
      {
         // Arrange
         ValuesController controller = new ValuesController();

         // Act
         IEnumerable<string> result = controller.Get();

         // Assert
         Assert.IsNotNull(result);
         Assert.AreEqual(2, result.Count());
         Assert.AreEqual("value1", result.ElementAt(0));
         Assert.AreEqual("value2", result.ElementAt(1));
      }

      [TestMethod]
      [TestCategory("Unit")]
      public void GetById()
      {
         // Arrange
         ValuesController controller = new ValuesController();

         // Act
         string result = controller.Get(5);

         // Assert
         Assert.AreEqual("value", result);
      }

      [TestMethod]
      [TestCategory("Unit")]
      public void Post()
      {
         // Arrange
         ValuesController controller = new ValuesController();

         // Act
         controller.Post("value");

         // Assert
      }

      [TestMethod]
      [TestCategory("Unit")]
      public void Put()
      {
         // Arrange
         ValuesController controller = new ValuesController();

         // Act
         controller.Put(5, "value");

         // Assert
      }

      [TestMethod]
      [TestCategory("Unit")]
      public void Delete()
      {
         // Arrange
         ValuesController controller = new ValuesController();

         // Act
         controller.Delete(5);

         // Assert
      }
   }
}
