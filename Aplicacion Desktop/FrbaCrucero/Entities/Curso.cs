using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Entities
{
    public class Curso
    {
        public long id { get; set; }
        public String name { get; set; }
        public String code { get; set; }
        public List<Person> students { get; set; }
        public int lvl { get; set; }

        public Curso(long Id, String Name, String Code, List<Person> Students, int Lvl)
        {
            id = Id;
            name = Name;
            code = Code;
            students = Students;
            lvl = Lvl;
        }
    }
}
