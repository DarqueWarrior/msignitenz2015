namespace PeopleTracker.Preview.Controllers
{
   using Microsoft.AspNet.Mvc;
   using Microsoft.Framework.OptionsModel;
   using PeopleTracker.Preview.Models;
   using System.Linq;
   using System.Net;

   public class PeopleController : Controller
   {
      private IRepository db;
      private IOptions<SiteOptions> siteOptions;

      public PeopleController(IRepository repo, IOptions<SiteOptions> options)
      {
         this.db = repo;
         this.siteOptions = options;
      }

      public IActionResult Create()
      {
         ViewData["WebApiBaseUrl"] = this.siteOptions?.Value.WebApiBaseUrl;

         return this.View();
      }

      [HttpPost]
      [ValidateAntiForgeryToken]
      public ActionResult Create([Bind("FirstName", "LastName")] Person person)
      {
         ViewData["WebApiBaseUrl"] = this.siteOptions.Value.WebApiBaseUrl;

         if (this.ModelState.IsValid)
         {
            this.db.AddPerson(person);
            return this.RedirectToAction("Index");
         }

         return View(person);
      }

      public ActionResult Delete(int? id)
      {
         ViewData["WebApiBaseUrl"] = this.siteOptions.Value.WebApiBaseUrl;

         if (id == null)
         {
            return new HttpStatusCodeResult((int)HttpStatusCode.BadRequest);
         }

         var person = this.db.People.First(p => p.ID == id);
         if (person == null)
         {
            return this.HttpNotFound();
         }

         return View(person);
      }

      [HttpPost]
      [ActionName("Delete")]
      [ValidateAntiForgeryToken]
      public ActionResult DeleteConfirmed(int id)
      {
         ViewData["WebApiBaseUrl"] = this.siteOptions.Value.WebApiBaseUrl;

         var person = this.db.People.FirstOrDefault(p => p.ID == id);
         if (person == null)
         {
            return this.HttpNotFound();
         }
         this.db.RemovePerson(person);
         return this.RedirectToAction("Index");
      }

      public ActionResult Details(int? id)
      {
         ViewData["WebApiBaseUrl"] = this.siteOptions.Value.WebApiBaseUrl;

         if (id == null)
         {
            return new HttpStatusCodeResult((int)HttpStatusCode.BadRequest);
         }
         var person = this.db.People.FirstOrDefault(p => p.ID == id);
         if (person == null)
         {
            return this.HttpNotFound();
         }
         return View(person);
      }

      public ActionResult Edit(int? id)
      {
         ViewData["WebApiBaseUrl"] = this.siteOptions.Value.WebApiBaseUrl;

         if (id == null)
         {
            return new HttpStatusCodeResult((int)HttpStatusCode.BadRequest);
         }
         var person = this.db.People.FirstOrDefault(p => p.ID == id);
         if (person == null)
         {
            return this.HttpNotFound();
         }
         return View(person);
      }

      [HttpPost]
      [ValidateAntiForgeryToken]
      public ActionResult Edit([Bind("ID", "FirstName", "LastName")] Person person)
      {
         ViewData["WebApiBaseUrl"] = this.siteOptions.Value.WebApiBaseUrl;

         if (this.ModelState.IsValid)
         {
            this.db.UpdatePerson(person);
            return this.RedirectToAction("Index");
         }
         return View(person);
      }

      public IActionResult Index()
      {
         ViewData["WebApiBaseUrl"] = this.siteOptions.Value.WebApiBaseUrl;

         return this.View(db.People.ToList());
      }
   }
}
