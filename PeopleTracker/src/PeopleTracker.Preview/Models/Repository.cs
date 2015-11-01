namespace PeopleTracker.Preview.Models
{
   using Microsoft.Framework.OptionsModel;
   using System;
   using System.Collections.Generic;
   using System.Net.Http;
   using System.Net.Http.Headers;

   public class Repository : IRepository
   {
      private IOptions<SiteOptions> siteOptions;

      public Repository(IOptions<SiteOptions> options)
      {
         this.siteOptions = options;
      }

      public IEnumerable<Person> People
      {
         get
         {
            var client = GetClient();

            var response = client.GetAsync("api/People").Result;

            if (response.IsSuccessStatusCode)
            {
               return response.Content.ReadAsAsync<IEnumerable<Person>>().Result;
            }

            return new Person[0];
         }
      }

      public bool AddPerson(Person person)
      {
         var client = GetClient();
         var response = client.PostAsJsonAsync<Person>("api/People", person).Result;

         return response.IsSuccessStatusCode;
      }

      public void RemovePerson(Person person)
      {
         var client = GetClient();

         // If you don't wait you will return to the list page before the item
         // is removed.
         client.DeleteAsync("api/People/" + person.ID).Wait();
      }

      public bool UpdatePerson(Person person)
      {
         var client = GetClient();
         var response = client.PutAsJsonAsync<Person>("api/People/" + person.ID, person).Result;

         return response.IsSuccessStatusCode;
      }

      private HttpClient GetClient()
      {
         HttpClient client = new HttpClient();
         client.BaseAddress = new Uri(siteOptions.Value.WebApiBaseUrl);

         // Add an Accept header for JSON format.
         client.DefaultRequestHeaders.Accept.Add(
             new MediaTypeWithQualityHeaderValue("application/json"));

         return client;
      }
   }
}
