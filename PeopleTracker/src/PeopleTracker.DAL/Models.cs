namespace PeopleTracker.DAL
{
   using System.Data.Entity;

   public partial class Models : DbContext
   {

      public Models() : base("name=Models")
      {
      }

      public virtual DbSet<Person> People { get; set; }

      protected override void OnModelCreating(DbModelBuilder modelBuilder)
      {
      }

   }
}
