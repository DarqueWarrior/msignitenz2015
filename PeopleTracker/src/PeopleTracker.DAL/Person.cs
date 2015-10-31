namespace PeopleTracker.DAL
{
   using System.ComponentModel.DataAnnotations;

   public partial class Person
   {

      public int ID { get; set; }

      [Required]
      [Display(Name = "First Name")]
      [StringLength(50)]
      public string FirstName { get; set; }

      [Required]
      [Display(Name = "Last Name")]
      [StringLength(50)]
      public string LastName { get; set; }

   }
}
