using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrbaCrucero.Entities;

namespace FrbaCrucero.Repository
{
    public interface SavePersonRepository
    {
        Person save(Person person);
        List<Person> save(List<Person> persons);
    }
}
