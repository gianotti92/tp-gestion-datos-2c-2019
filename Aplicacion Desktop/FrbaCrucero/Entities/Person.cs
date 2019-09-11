using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Entities
{
    public class Person
    {
        public long id { get; set; }
        public String identificatioNumber { get; set; }
        public String name { get; set; }
        public String lastName { get; set; }
        public int age { get; set; }

        public Person(long Id, String IdentificatioNumber, String Name, String LastName, int Age)
        {
            id = Id;
            identificatioNumber = IdentificatioNumber;
            name = Name;
            lastName = LastName;
            age = Age;
        }
    }
}
