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
    }
}