using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrbaCrucero.Entities;
using System.Diagnostics;
using System.Windows.Forms;

namespace FrbaCrucero.Repository
{
    public class SavePersonDao : SavePersonRepository
    {
        public Person save(Person person)
        {
            var formPopup = new Form();
            formPopup.Show();
            Console.WriteLine("person save ok");
            return person;
        }
        public List<Person> save(List<Person> persons)
        {
            var formPopup = new Form();
            Console.WriteLine("person list save ok");
            formPopup.Show();
            return persons;
        }
    }
}
