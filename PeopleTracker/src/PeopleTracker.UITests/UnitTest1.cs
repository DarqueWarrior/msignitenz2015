namespace PeopleTracker.UITests
{
   using Microsoft.VisualStudio.TestTools.UnitTesting;
   using OpenQA.Selenium.Chrome;
   using OpenQA.Selenium.Firefox;
   using OpenQA.Selenium.IE;
   using OpenQA.Selenium.Remote;

   [TestClass]
   public class UnitTest1
   {
      private string baseURL;
      private RemoteWebDriver driver;
      private string browser;
      public TestContext TestContext { get; set; }

      [TestMethod]
      public void TestMethod1()
      {
      }

      /// <summary>
      /// Use TestCleanup to run code after each test has run
      /// </summary>
      [TestCleanup()]
      public void MyTestCleanup()
      {
         driver.Quit();
      }

      [TestInitialize()]
      public void MyTestInitialize()
      {
         browser = this.TestContext.Properties["browser"] != null ? this.TestContext.Properties["browser"].ToString() : "ie";

         switch (browser)
         {
            case "firefox":
               driver = new FirefoxDriver();
               break;

            case "chrome":
               driver = new ChromeDriver();
               break;

            default:
               driver = new InternetExplorerDriver();
               break;
         }

         // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
         if (this.TestContext.Properties["webAppUrl"] != null)
         {
            this.baseURL = this.TestContext.Properties["webAppUrl"].ToString();
         }
         else
         {
            this.baseURL = "http://{yourDockerHostName}.cloudapp.azure.com/";
         }
      }
   }
}
