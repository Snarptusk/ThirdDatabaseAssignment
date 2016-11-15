namespace ThirdDatabaseAssignment
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class PersonContext : DbContext
    {
        public PersonContext()
            : base("name=PersonContext")
        {
        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Adress> Adresses { get; set; }
        public DbSet<Phone> Phones { get; set; }
    }
}