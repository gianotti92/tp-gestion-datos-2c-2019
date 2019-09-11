using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrbaCrucero.Repository;
using FrbaCrucero.Entities;

namespace FrbaCrucero.Service
{
    public class SavePersonServiceImpl : SavePersonService
    {
        public SavePersonRepository savePersonRepository { get; set; }

        public SavePersonServiceImpl(SavePersonRepository SavePersonRepository)
        {
            savePersonRepository = SavePersonRepository;
        }

        public Person save(Person person)
        {
           return savePersonRepository.save(person);
        }
        public List<Person> save(List<Person> persons)
        {
            return savePersonRepository.save(persons);
        }

    }
}