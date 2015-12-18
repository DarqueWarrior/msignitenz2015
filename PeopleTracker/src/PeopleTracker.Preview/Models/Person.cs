namespace PeopleTracker.Preview.Models
{
   using System.ComponentModel.DataAnnotations;

   public class Person
   {
      public int ID { get; set; }

      [Required]
      public string FirstName { get; set; }

      [Required]
      public string LastName { get; set; }
   }
}
