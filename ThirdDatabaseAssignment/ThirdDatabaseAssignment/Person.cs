using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdDatabaseAssignment
{
    public class Person
    {
        public int PersonID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Adress> PersonAdress { get; set; }
        public List<Phone> PersonPhone { get; set; }
    }
}
