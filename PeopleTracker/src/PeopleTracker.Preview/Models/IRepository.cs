namespace PeopleTracker.Preview.Models
{
   using System.Collections.Generic;

   public interface IRepository
   {
      IEnumerable<Person> People { get; }
      bool AddPerson(Person person);
      void RemovePerson(Person person);
      bool UpdatePerson(Person person);
   }
}
